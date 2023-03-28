using serverside.Core.Errors;
using System.Net;

namespace serverside.Core.Responses
{
    public class BasicResponse
    {
        /// <summary>
        ///     Gets of sets the error data of the response
        /// </summary>
        /// <value>The error detail if error occured, null if not</value>
        public Error Error { get; set; } = null;

        /// <summary>
        ///     Additional information of the request result
        /// </summary>
        public string Message { get; set; } = "ok";

        /// <summary>
        /// Gets of http status code of the request
        /// </summary>
        /// <value>Corresponding Http error code if error occured</value>
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
    }
}
