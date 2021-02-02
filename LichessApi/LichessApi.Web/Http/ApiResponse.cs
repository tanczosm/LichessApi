#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

namespace LichessApi.Web.Http
{
    public class ApiResponse<T> : IApiResponse<T>
    {
        public ApiResponse(IResponse response, T? body = default)
        {
            Ensure.ArgumentNotNull(response, nameof(response));

            Body = body;
            Response = response;
        }

        public T? Body { get; set; }

        public IResponse Response { get; set; }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
