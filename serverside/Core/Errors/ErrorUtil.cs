namespace serverside.Core.Errors
{
    public static class ErrorUtil
    {
        
        public static readonly Error InternalServerError = new Error() { code = "10000", message = "Internal Server Error" };
        public static readonly Error InputDataError = new Error() { code = "10001", message = "Please Input" };
    }
}