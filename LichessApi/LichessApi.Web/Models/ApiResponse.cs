using System;
using System.Collections.Generic;

namespace LichessApi.Models
{
    public class ApiResponse<T>
        where T: class
    {
        public int StatusCode { get; set; }

        public string ErrorMessage { get; set; }

        public T Result { get; set; }

        public Exception ErrorException;

    }
}
