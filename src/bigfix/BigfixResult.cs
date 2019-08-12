namespace Bigfix
{
    // IET always returns this base info and wraps the array of results in response data
    public class BigfixResult<T>
    {
        public ResponseData<T> ResponseData { get; set; }
    }
}