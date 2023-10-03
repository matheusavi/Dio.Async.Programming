using Dio.Async.Programming;
using System.Diagnostics;

string opcao;

do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Fazer comida (síncrono)");
    Console.WriteLine("2 - Fazer comida (assíncrono)");
    Console.WriteLine("3 - Ler arquivo (síncrono)");
    Console.WriteLine("4 - Ler arquivo (assíncrono)");
    Console.WriteLine("5 - Ler do banco de dados (síncrono)");
    Console.WriteLine("6 - Ler do banco de dados (assíncrono)");
    Console.WriteLine("7 - Fazer request HTTP");
    Console.WriteLine("8 - Comparando requests em sequencial e paralelo");
    Console.WriteLine("9 - Thread unsafe");
    Console.WriteLine("10 - Cancelando uma operação assíncrona");
    Console.WriteLine("0 - Sair");
    Console.Write("Opção: ");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            var cozinha = new Cozinha();
            cozinha.FazerComida();
            break;

        case "2":
            var cozinhaAsync = new Cozinha();
            await cozinhaAsync.FazerComidaAsync();
            break;

        case "3":
            LendoDeArquivos.LerArquivo();
            break;

        case "4":
            await LendoDeArquivos.LerArquivoAsync();
            break;

        case "5":
            var interagindoComBanco = new InteragindoComBanco();
            interagindoComBanco.LerDoBanco();
            break;

        case "6":
            var interagindoComBancoAsync = new InteragindoComBanco();
            await interagindoComBancoAsync.LerDoBancoAsync();
            break;

        case "7":
            var retorno = await FazendoRequestHttp.GetRequest();
            Console.WriteLine(retorno); 
            break;

        case "8":
            var stopwatch = new Stopwatch();

            stopwatch.Start();
            await FazendoRequestHttp.GetRequestSequential();
            stopwatch.Stop();
            Console.WriteLine($"Requests em sequência levaram {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            await FazendoRequestHttp.GetRequestParallel();
            stopwatch.Stop();
            Console.WriteLine($"Requests em paralelo levaram {stopwatch.ElapsedMilliseconds} ms");
            break;

        case "9":
            ThreadSafe.ThreadUnsafe();
            break;

        case "10":
            await CancellationTokenExemplos.ExecutarCancellationToken();
            break;

        case "0":
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    Console.WriteLine();
} while (opcao != "0");