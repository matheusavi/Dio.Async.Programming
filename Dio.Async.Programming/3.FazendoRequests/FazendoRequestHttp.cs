namespace Dio.Async.Programming;

internal class FazendoRequestHttp
{
    public static async Task GetRequest()
    {
        using var httpClient = new HttpClient();
        var respostaHttp = await httpClient.GetAsync("http://localhost:5223/api/controllersimples");
        var resultado = await respostaHttp.Content.ReadAsStringAsync();
    }

    public static async Task GetRequestSequential()
    {
        using var httpClient = new HttpClient();
        for (var i = 0; i < 5; i++)
        {
            var respostaHttp = await httpClient.GetAsync("http://localhost:5223/api/controllersimples");
            var resultado = await respostaHttp.Content.ReadAsStringAsync();
        }
    }

    public static async Task GetRequestParallel()
    {
        using var httpClient = new HttpClient();
        var tasks = new List<Task>();
        for (var i = 0; i < 5; i++)
        {
            tasks.Add(httpClient.GetAsync("http://localhost:5223/api/controllersimples"));
        }

        await Task.WhenAll(tasks);
    }
}
