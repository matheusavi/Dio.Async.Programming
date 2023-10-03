namespace Dio.Async.Programming;

internal class ThreadSafe
{
    public static void ThreadUnsafe()
    {
        var pessoa = new Pessoa();
        var tasks = new List<Task>();

        for (int i = 0; i < 1000; i++)
        {
            tasks.Add(Task.Run(() => pessoa.IncrementarIdade()));
        }

        Task.WaitAll(tasks.ToArray());

        Console.WriteLine(pessoa.Idade);
    }
}
