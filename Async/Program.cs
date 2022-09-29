class Program
{
    static async Task Main(string[] args)
    {
        // // получаем текущий поток
        // Thread currentThread = Thread.CurrentThread;
        // //получаем имя потока
        // Console.WriteLine($"Имя потока: {currentThread.Name}");
        // currentThread.Name = "Метод Main";
        // Console.WriteLine($"Имя потока: {currentThread.Name}");
        // Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
        // Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
        // Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
        // Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
        await PrintAsync();   // вызов асинхронного метода
        Console.WriteLine("Некоторые действия в методе Main");
 
 
        void Print()
        {
            Thread.Sleep(3000);     // имитация продолжительной работы
            Console.WriteLine("Hello METANIT.COM");
        }
 
        // определение асинхронного метода
        async Task PrintAsync()
        {
            Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
            await Task.Run(() => Print());                // выполняется асинхронно
            Console.WriteLine("Конец метода PrintAsync");
        }
    }
}