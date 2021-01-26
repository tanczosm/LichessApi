using LichessApi.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi.Util.Converters
{
    class RatingEntryConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(RatingEntry);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;

            var array = JArray.Load(reader);
            var ratingEntry = (existingValue as RatingEntry ?? new RatingEntry());
            ratingEntry.Year = Convert.ToInt32(array.ElementAtOrDefault(0));
            ratingEntry.Month = Convert.ToInt32(array.ElementAtOrDefault(1));
            ratingEntry.Day = Convert.ToInt32(array.ElementAtOrDefault(2));
            ratingEntry.Rating = Convert.ToInt32(array.ElementAtOrDefault(3));

            return ratingEntry;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var ratingEntry = (RatingEntry)value;
            serializer.Serialize(writer, new[] { ratingEntry.Year, ratingEntry.Month, ratingEntry.Day, ratingEntry.Rating });
        }
    }
}
