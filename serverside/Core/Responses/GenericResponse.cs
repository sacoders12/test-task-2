using System.Collections.Generic;

namespace serverside.Core.Responses
{
    public class GenericResponse<T> : BasicResponse
    {
        public T Data { get; set; }
        public IDictionary<string, object> Meta { get; set; }
    }
}
