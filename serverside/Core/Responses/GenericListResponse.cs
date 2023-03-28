using System.Collections.Generic;

namespace serverside.Core.Responses
{
    public class GenericListResponse<T> : BasicResponse
    {
        public ICollection<T> Data { get; set; }
        public IDictionary<string, object> Meta { get; set; }
    }
}
