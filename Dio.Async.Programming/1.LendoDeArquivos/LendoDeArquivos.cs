namespace Dio.Async.Programming;

internal class LendoDeArquivos
{
    private const string _path = "./1.LendoDeArquivos/arquivo.txt";

    public static void LerArquivo()
    {
        using var reader = File.OpenText(_path);
        var retorno = reader.ReadToEnd();
        Console.WriteLine(retorno);
    }

    public static async Task LerArquivoAsync()
    {
        using var reader = File.OpenText(_path);
        var retorno = await reader.ReadToEndAsync();
        await Console.Out.WriteLineAsync(retorno);
    }    
}
