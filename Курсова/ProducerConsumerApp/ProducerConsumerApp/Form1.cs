using System; // Простір імен для основних типів даних і методів
using System.Collections.Concurrent; // Простір імен для потокобезпечних колекцій, таких як ConcurrentQueue
using System.Diagnostics; // Простір імен для діагностики і відстеження
using System.IO.MemoryMappedFiles; // Простір імен для роботи з файлами, відображеними в пам'ять
using System.Threading; // Простір імен для роботи з потоками і синхронізацією
using System.Windows.Forms; // Простір імен для створення Windows Forms додатків

namespace ProducerConsumerApp // Оголошення простору імен для додатку
{
    public partial class Form1 : Form // Клас Form1 наслідує клас Form для створення форми
    {
        private int producerCount = 2; // Кількість потоків-виробників
        private int consumerCount = 1; // Кількість потоків-споживачів
        private Thread[] producerThreads; // Масив потоків виробників
        private Thread consumerThread; // Потік споживача
        private SemaphoreSlim emptySemaphore; // Семафор для контролю порожніх місць у черзі
        private SemaphoreSlim fullSemaphore; // Семафор для контролю заповнених місць у черзі
        private ConcurrentQueue<Product> queue; // Потокобезпечна черга для продуктів
        private MemoryMappedFile mmf; // Файл, відображений в пам'ять
        private MemoryMappedViewAccessor accessor; // Доступ до відображеного в пам'ять файлу
        private CancellationTokenSource cancellationTokenSource; // Токен для скасування роботи потоків

        public Form1() // Конструктор класу
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializeSynchronizationObjects(); // Ініціалізація об'єктів синхронізації
            InitializeMemoryMappedFile(); // Ініціалізація файлу, відображеного в пам'ять
        }

        private void InitializeSynchronizationObjects() // Метод для ініціалізації об'єктів синхронізації
        {
            emptySemaphore = new SemaphoreSlim(10); // Створення семафора з початковим і максимальним значенням 10
            fullSemaphore = new SemaphoreSlim(0); // Створення семафора з початковим значенням 0
            queue = new ConcurrentQueue<Product>(); // Створення потокобезпечної черги
        }

        private void InitializeMemoryMappedFile() // Метод для ініціалізації файлу, відображеного в пам'ять
        {
            mmf = MemoryMappedFile.CreateOrOpen("ProducerConsumerMMF", 1024); // Створення або відкриття файлу розміром 1024 байти
            accessor = mmf.CreateViewAccessor(); // Створення доступу до файлу
        }

        private void StartProducers() // Метод для запуску потоків-виробників
        {
            producerThreads = new Thread[producerCount]; // Ініціалізація масиву потоків виробників
            for (int i = 0; i < producerCount; i++) // Цикл для створення і запуску потоків виробників
            {
                int producerId = i; // Збереження ідентифікатора виробника
                producerThreads[i] = new Thread(() => Producer(producerId, cancellationTokenSource.Token)); // Створення нового потоку для виробника
                producerThreads[i].Start(); // Запуск потоку виробника
            }
        }

        private void StartConsumer() // Метод для запуску потоку-споживача
        {
            consumerThread = new Thread(() => Consumer(cancellationTokenSource.Token)); // Створення нового потоку для споживача
            consumerThread.Start(); // Запуск потоку споживача
        }

        private void Producer(int producerId, CancellationToken token) // Метод, що виконується потоком-виробником
        {
            Random random = new Random(); // Створення об'єкта для генерації випадкових чисел
            try
            {
                while (!token.IsCancellationRequested) // Цикл, що виконується поки не запитано скасування
                {
                    var product = new Product // Створення нового продукту
                    {
                        Id = random.Next(1000), // Встановлення випадкового ідентифікатора
                        Name = $"Product{producerId}-{random.Next(1000)}", // Встановлення імені продукту
                        CreationTime = DateTime.Now // Встановлення часу створення продукту
                    };

                    emptySemaphore.Wait(token); // Очікування наявності вільного місця у черзі з врахуванням токену скасування

                    lock (queue) // Блокування черги для безпечного доступу з різних потоків
                    {
                        queue.Enqueue(product); // Додавання продукту до черги
                        Console.WriteLine($"Producer {producerId} produced: {product}"); // Виведення повідомлення у консоль
                        BeginInvoke(new Action(() =>
                        {
                            listBox1.Items.Add(product); // Додавання продукту до ListBox на формі
                        }));
                    }

                    fullSemaphore.Release(); // Збільшення лічильника заповнених місць
                    Thread.Sleep(1000); // Затримка для симуляції роботи виробника
                }
            }
            catch (OperationCanceledException) // Обробка виключення при скасуванні операції
            {
                // Коректне завершення роботи
            }
        }

        private void Consumer(CancellationToken token) // Метод, що виконується потоком-споживачем
        {
            try
            {
                while (!token.IsCancellationRequested) // Цикл, що виконується поки не запитано скасування
                {
                    fullSemaphore.Wait(token); // Очікування наявності заповненого місця у черзі з врахуванням токену скасування

                    if (queue.TryDequeue(out Product product)) // Спроба взяти продукт з черги
                    {
                        lock (accessor) // Блокування доступу до файлу, відображеного в пам'ять
                        {
                            // Зберігаємо лише ID продукту у MemoryMappedFile для простоти
                            accessor.Write(0, product.Id); // Запис ідентифікатора продукту у файл
                        }

                        Invoke(new Action(() =>
                        {
                            listBox1.Items.RemoveAt(0); // Видалення першого елементу з ListBox на формі
                            Console.WriteLine($"Consumer consumed: {product}"); // Виведення повідомлення у консоль
                        }));

                        emptySemaphore.Release(); // Збільшення лічильника вільних місць
                    }

                    Thread.Sleep(1000); // Затримка для симуляції роботи споживача
                }
            }
            catch (OperationCanceledException) // Обробка виключення при скасуванні операції
            {
                // Коректне завершення роботи
            }
        }

        private void startButton_Click(object sender, EventArgs e) // Обробник натискання кнопки "Start"
        {
            producerCount = (int)producerCountNumericUpDown.Value; // Отримання кількості виробників з NumericUpDown
            consumerCount = (int)consumerCountNumericUpDown.Value; // Отримання кількості споживачів з NumericUpDown
            cancellationTokenSource = new CancellationTokenSource(); // Створення нового токену для скасування
            InitializeSynchronizationObjects(); // Ініціалізація об'єктів синхронізації
            StartProducers(); // Запуск потоків виробників
            StartConsumer(); // Запуск потоку споживача
        }

        private void stopButton_Click(object sender, EventArgs e) // Обробник натискання кнопки "Stop"
        {
            cancellationTokenSource.Cancel(); // Запит на скасування роботи потоків
            foreach (var thread in producerThreads) // Перебір всіх потоків виробників
            {
                thread?.Join(); // Очікування завершення роботи потоку
            }
            consumerThread?.Join(); // Очікування завершення роботи потоку споживача
            InitializeSynchronizationObjects(); // Оновлення об'єктів синхронізації після зупинки
        }
    }

    public class Product // Клас для представлення продукту
    {
        public int Id { get; set; } // Ідентифікатор продукту
        public string Name { get; set; } // Ім'я продукту
        public DateTime CreationTime { get; set; } // Час створення продукту

        public override string ToString() // Перевизначення методу ToString для зручного виведення продукту
        {
            return $"ID: {Id}, Name: {Name}, Created: {CreationTime}"; // Повернення рядка з інформацією про продукт
        }
    }
}
