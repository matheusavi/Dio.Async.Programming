namespace Dio.Async.Programming;
public class CancellationTokenExemplos
{
    public static async Task ExecutarCancellationToken()
    {
        var cancellationTokenSource = new CancellationTokenSource();
        
        cancellationTokenSource.CancelAfter(2000);

        var task = OperacaoDemorada(cancellationTokenSource.Token);

        await Task.Delay(5000);

        await task;
    }

    public static async Task OperacaoDemorada(CancellationToken cancellationToken)
    {
        Console.WriteLine("Iniciando operação demorada...");

        try
        {
            for (int i = 0; i < 10; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                Console.WriteLine($"Iteração {i}");

                await Task.Delay(1000, cancellationToken);
            }

            Console.WriteLine("Operação demorada concluída com sucesso.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operação demorada foi cancelada.");
        }
    }
}