namespace PracticalWork_15._0
{
    internal class Program
    {
        static async Task Main()
        {
            int numTasks = 5; // Количество задач
            Task[] tasks = new Task[numTasks];

            for (int i = 0; i < numTasks; i++)
            {
                // Генерируем случайную задержку от 1 до 5 секунд
                Random random = new Random();
                int delay = random.Next(1000, 5000); // задержка в миллисекундах

                // Создаём и запускаем асинхронную задачу
                tasks[i] = PrintMessageWithDelayAsync(delay);
            }

            // Ждём завершения всех задач
            await Task.WhenAll(tasks);

            Console.WriteLine("Все задачи завершены.");
        }

        static async Task PrintMessageWithDelayAsync(int delay)
        {
            string taskId = Task.CurrentId.ToString();

            await Task.Delay(delay); // Асинхронная задержка

            Console.WriteLine($"Сообщение из задачи {taskId}. Задержка: {delay / 1000.0:F2} сек.");
        }
    }
}
