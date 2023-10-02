using Dio.Async.Programming;
using System.Diagnostics;

//Lendo arquivos
LendoDeArquivos.LerArquivo();

await LendoDeArquivos.LerArquivoAsync();

//Utilizando com banco de dados
var interagindoComBanco = new InteragindoComBanco();
interagindoComBanco.LerDoBanco();
await interagindoComBanco.LerDoBancoAsync();


//Fazendo request http
await FazendoRequestHttp.GetRequest();

//Porque usar async?
var stopwatch = new Stopwatch();

stopwatch.Start();

await FazendoRequestHttp.GetRequestSequential();

stopwatch.Stop();
Console.WriteLine($"Requests em sequencia levaram {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
await FazendoRequestHttp.GetRequestParallel();
stopwatch.Stop();
Console.WriteLine($"Requests em paralelo levaram {stopwatch.ElapsedMilliseconds} ms");

