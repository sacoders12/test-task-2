namespace serverside.Core.Errors
{
    public class Error
    {
        /// <summary>
        ///     One of a server-defined set of error codes.
        /// </summary>
        public string code = null;

        /// <summary>
        ///     A human-readable representation of the error.
        /// </summary>
        public string message = null;

        /// <summary>
        ///     The target of the error.
        /// </summary>
        public string target = null;

        /// <summary>
        ///     An array of details about specific errors that led to this reported error.
        /// </summary>
        public object[] details = null;
    }
}
