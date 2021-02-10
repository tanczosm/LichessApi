using System.Collections.Concurrent;
using System.Reflection;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;
using LichessApi.Web.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web
{
    public abstract class RequestParams
    {
        private static readonly ConcurrentDictionary<Type, List<(PropertyInfo, JsonPropertyAttribute)>> _bodyParamsCache =
          new();

        public JObject BuildBodyParams()
        {
            // Make sure everything is okay before building body params
            CustomEnsure();

            var body = new JObject();
            var type = GetType();

            if (!_bodyParamsCache.IsEmpty && _bodyParamsCache.ContainsKey(type))
            {
                foreach (var (info, attribute) in _bodyParamsCache[type])
                {
                    AddBodyParam(body, info, attribute);
                }
            }
            else
            {
                var bodyProps = GetType()
                  .GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
                  .Where(prop => prop.GetCustomAttributes(typeof(JsonPropertyAttribute), true).Length > 0);

                _bodyParamsCache[type] = new List<(PropertyInfo, JsonPropertyAttribute)>();
                foreach (var prop in bodyProps)
                {
                    var attribute = prop.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute != null)
                    {
                        _bodyParamsCache[type].Add((prop, attribute));
                        AddBodyParam(body, prop, attribute);
                    }
                }
            }

            var json = body.ToString();

            return body;
        }

        private void AddBodyParam(JObject body, PropertyInfo prop, JsonPropertyAttribute attribute)
        {
            object? value = prop.GetValue(this);
            if (value != null)
            {
                body[attribute.PropertyName ?? prop.Name] = JToken.FromObject(value,
                    JsonSerializer.CreateDefault(new JsonSerializerSettings { Converters = { new StringEnumConverter() } }));
            }
        }

        private static readonly ConcurrentDictionary<Type, List<(PropertyInfo, JsonPropertyAttribute)>> _queryParamsCache =
          new();

        public Dictionary<string, string> BuildQueryParams()
        {
            // Make sure everything is okay before building query params
            CustomEnsure();

            var queryParams = new Dictionary<string, string>();
            var type = GetType();

            if (!_queryParamsCache.IsEmpty && _queryParamsCache.ContainsKey(type))
            {
                foreach (var (info, attribute) in _queryParamsCache[type])
                {
                    AddQueryParam(queryParams, info, attribute);
                }
            }
            else
            {
                var queryProps = GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)
                .Where(prop => prop.GetCustomAttributes(typeof(JsonPropertyAttribute), true).Length > 0);

                _queryParamsCache[type] = new List<(PropertyInfo, JsonPropertyAttribute)>();
                foreach (var prop in queryProps)
                {
                    var attribute = prop.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute != null)
                    {
                        _queryParamsCache[type].Add((prop, attribute));
                        AddQueryParam(queryParams, prop, attribute);
                    }
                }
            }

            AddCustomQueryParams(queryParams);

            return queryParams;
        }

        private void AddQueryParam(Dictionary<string, string> queryParams, PropertyInfo prop, JsonPropertyAttribute attribute)
        {
            object? value = prop.GetValue(this);
            if (value != null)
            {
                if (value is IList<string> list)
                {
                    if (list.Count > 0)
                    {
                        var str = string.Join(",", list);
                        queryParams.Add(attribute.PropertyName ?? prop.Name, str);
                    }
                }
                else if (value is bool valueAsBool)
                {
                    queryParams.Add(attribute.PropertyName ?? prop.Name, valueAsBool ? "true" : "false");
                }
                else if (value is System.Enum valueAsEnum)
                {
                    var enumType = valueAsEnum.GetType();
                    var valueList = new List<string>();
                    
                    valueList.Add(ToEnumString(valueAsEnum));
                    
                    queryParams.Add(attribute.PropertyName ?? prop.Name, string.Join(",", valueList));
                }
                else
                {
                    queryParams.Add(attribute.PropertyName ?? prop.Name, value.ToString() ?? throw new ApiException("ToString returned null for query parameter"));
                }
            }
        }

        private string ToEnumString<T>(T instance)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                instance,
                Newtonsoft.Json.Formatting.None,
                new Newtonsoft.Json.JsonSerializerSettings()
                {
                    Converters = new List<Newtonsoft.Json.JsonConverter>
                    {
                        new Newtonsoft.Json.Converters.StringEnumConverter()
                    }
                }).Replace("\"", "");
        }

        protected virtual void CustomEnsure() { }
        protected virtual void AddCustomQueryParams(Dictionary<string, string> queryParams) { }
    }


}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
