using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BarberAppDLL.Dto
{
    public class ErrorDto
    {
        public string Message { get; set; }
        public string Property { get; set; }
    }

    // This is a generic class that all api actions now return
    public class ApiResponse
    {

        public ApiResponse()
        {
            Errors = new List<ErrorDto>();
        }

        public ApiResponse(object data)
        {
            Data = data;
            Errors = new List<ErrorDto>();
        }

        [DataMember(EmitDefaultValue = false)]
        public object Data { get; set; } // this generic object stores the actual results we want.

        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<ErrorDto> Errors { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool IsSuccess => !Errors.Any();

        [DataMember(EmitDefaultValue = false)]
        public int StatusCode { get; set; }
    }

    public class ApiResponse<T>
    {
        public ApiResponse()
        {
            Errors = new List<ErrorDto>();
        }

        public ApiResponse(T data)
        {
            Data = data;
            Errors = new List<ErrorDto>();
        }

        [DataMember(EmitDefaultValue = false)]
        public T Data { get; set; } 

        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<ErrorDto> Errors { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool IsSuccess => !Errors.Any();

        [DataMember(EmitDefaultValue = false)]
        public int StatusCode { get; set; }
    }
}
