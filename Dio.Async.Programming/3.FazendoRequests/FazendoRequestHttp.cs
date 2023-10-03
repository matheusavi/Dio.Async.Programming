namespace Dio.Async.Programming;

internal class FazendoRequestHttp
{
    private const string _requestUri = "http://localhost:5223/api/controllersimples";

    public static async Task<string> GetRequest()
    {
        return string.Empty;
    }

    public static async Task GetRequestSequential()
    {
    }

    public static async Task GetRequestParallel()
    {
    }
}
