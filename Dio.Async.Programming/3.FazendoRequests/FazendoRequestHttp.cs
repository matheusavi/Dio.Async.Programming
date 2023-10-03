namespace Dio.Async.Programming;

internal class FazendoRequestHttp
{
    private const string _requestUri = "http://localhost:5223/api/controllersimples";

    public static async Task<string> GetRequest()
    {
        using var httpClient = new HttpClient();
        var respostaHttp = await httpClient.GetAsync(_requestUri);
        return await respostaHttp.Content.ReadAsStringAsync();
    }

    public static async Task GetRequestSequential()
    {
        using var httpClient = new HttpClient();
        for (var i = 0; i < 5; i++)
        {
            var respostaHttp = await httpClient.GetAsync(_requestUri);
            var resultado = await respostaHttp.Content.ReadAsStringAsync();
        }
    }

    public static async Task GetRequestParallel()
    {
        using var httpClient = new HttpClient();
        var tasks = new List<Task>();
        for (var i = 0; i < 5; i++)
        {
            tasks.Add(httpClient.GetAsync(_requestUri));
        }

        await Task.WhenAll(tasks);
    }
}
