using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using KeybordSimulator.Models;
using KeybordSimulator.Shared.Services;

namespace KeybordSimulator.Services
{
    /// <summary>
    /// Служба симулятора, которая управляет прогрессом прохождения уровня
    /// </summary>
    public class SimulatorService : IDisposable
    {
        /// <summary>
        /// Ивент обновления данных симулятора
        /// </summary>
        public event Action OnUpdateSimulator;
        /// <summary>
        /// Ивент выйгрыша
        /// </summary>
        public event Action OnWin;
        /// <summary>
        /// Ивент проигрыша
        /// </summary>
        public event Action OnLose;
        /// <summary>
        /// Модель симулятора(тольо для чтения)
        /// </summary>
        public SimulatorModel SimulatorModel { get; }
        /// <summary>
        /// Модель карты симулятора, которому нельзя присваивать новый объект из вне
        /// </summary>
        public SimulatorMapModel SimulatorMapModel { get; private set; }
        /// <summary>
        /// Токен, необходимый для уведомления, что поток этой службы завершил работу
        /// </summary>
        public CancellationToken CancellationToken { get; }
        /// <summary>
        /// Таймер в секундах
        /// </summary>
        public int Timer { get; set; }
        /// <summary>
        /// Макс таймер в секундах, которому нельзя присваивать занчение из вне
        /// </summary>
        public int MaxTimer { get; private set; }
        /// <summary>
        /// Интервал времени таймера, необходим для визуализации таймера
        /// </summary>
        public TimeSpan TimerSpan => new TimeSpan(0, 0, MaxTimer - Timer);
        /// <summary>
        /// Количество ошибок
        /// </summary>
        public int Errors { get; set; }
        /// <summary>
        /// Количестов нажатий клавиш в секунду
        /// </summary>
        public int KeyPressCount { get; set; }
        /// <summary>
        /// Прошлая скорость печатания
        /// </summary>
        public int LastSpeed { get; set; }
        /// <summary>
        /// Нынешняя скорость печатания
        /// </summary>
        public int SpeedCount { get; set; }
        /// <summary>
        /// Проверка на то, стоит ли пауза у службы, нельзя присваивать значение из вне
        /// </summary>
        public bool IsPaused { get; private set; }

        /// <summary>
        /// Время, которое спит поток в милисекундах
        /// </summary>
        private int ThreadUpdateTimeout => 1000 / SimulatorServiceConsts.ThreadUpdatePerSecond;
        /// <summary>
        /// Поле для чтения, в ккотором содержится рабочий пото
        /// </summary>
        private readonly Thread _workThread;
        /// <summary>
        /// Исхоник Токена, наобходим, чтобы послать сигнал отмены
        /// </summary>
        private readonly CancellationTokenSource _sourceToken;

        /// <summary>
        /// Конструтор создания типа, в котором первоначально инициализирутся служба
        /// </summary>
        /// <param name="simulatorModel">Модель симулятора</param>
        public SimulatorService(SimulatorModel simulatorModel)
        {
            SimulatorModel = simulatorModel;
            _sourceToken = new CancellationTokenSource();
            CancellationToken = _sourceToken.Token;
            _workThread = new Thread(() => Work());
        }
        /// <summary>
        /// Рандомная гененрация карты времени, а также таймера
        /// </summary>
        public void GenerateSimulatorMap()
        {
            List<string> words = new List<string>();
            foreach (var wordModel in SimulatorModel.Level.Words)
            {
                if (wordModel == null)
                {
                    continue;
                }
                if (string.IsNullOrEmpty(wordModel.Word))
                {
                    continue;
                }
                words.Add(wordModel.Word);
            }
            Random randomToCountWords = new Random(DateTime.Now.Ticks.GetHashCode());
            int minWords = SimulatorModel.Level.MinWords;
            int maxWords = SimulatorModel.Level.MaxWords;
            ValidateMinAndMaxWords(ref minWords, ref maxWords);
            var countWords = randomToCountWords.Next(minWords, maxWords);
            List<char> generatedChars = new List<char>();
            for (int i = 0; i < countWords; i++)
            {
                Random randomToToWord = new Random(DateTime.Now.Ticks.GetHashCode() + i);
                var randomIndex = randomToToWord.Next(0, words.Count);
                var randomWord = words[randomIndex];
                foreach (var charToWord in randomWord)
                {
                    generatedChars.Add(charToWord);
                }
                if (i == countWords - 1)
                {
                    continue;
                }
                generatedChars.Add(' ');
            }
            var map = new SimulatorMapModel(generatedChars);
            GenerateTimer(generatedChars);
            map.CountWords = countWords;
            SimulatorMapModel = map;
        }
        /// <summary>
        /// генерация конечного результата, для создания текстового файла, если пользователь проешл уровень
        /// </summary>
        /// <returns></returns>
        internal string GenerateResult()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Пользователь - {SimulatorModel.UserName}");
            stringBuilder.AppendLine($"Уровень - {SimulatorModel.Level.LevelName}");
            stringBuilder.AppendLine($"Скорость - {SpeedCount} слов/м");
            stringBuilder.AppendLine($"Ошибок - {Errors}");

            return stringBuilder.ToString();
        }
        /// <summary>
        /// Метод запуска службы
        /// </summary>
        public void Start()
        {
            _workThread.Start();
            OnUpdateSimulator?.Invoke();
        }
        /// <summary>
        /// Метод работы службы, который выполняет отдельный поток
        /// </summary>
        public void Work()
        {
            while (!_sourceToken.IsCancellationRequested)
            {
                if (!IsPaused)
                {
                    OnUpdateSimulator?.Invoke();
                }
                Thread.Sleep(ThreadUpdateTimeout);
            }
        }
        /// <summary>
        /// Метод продолжения работы службы
        /// </summary>
        public void Resume()
        {
            IsPaused = false;
        }
        /// <summary>
        /// Метод, который ставит на паузу работу службы
        /// </summary>
        public void Pause()
        {
            IsPaused = true;
        }
        /// <summary>
        /// Метод, который останавливает работу службы
        /// </summary>
        public void Stop()
        {
            IsPaused = true;
            _sourceToken.Cancel();
        }
        /// <summary>
        /// Метод, который освобождает неуправляемые ресурсы 
        /// </summary>
        public void Dispose()
        {
            _sourceToken.Dispose();
        }
        /// <summary>
        /// Метод, который вызывает ивент победы 
        /// </summary>
        public void Win()
        {
            OnUpdateSimulator?.Invoke();
            Stop();
            OnWin?.Invoke();
        }
        /// <summary>
        /// Метод, оторый вызывает ивент проигрыша
        /// </summary>
        public void Lose()
        {
            OnUpdateSimulator?.Invoke();
            Stop();
            OnLose?.Invoke();
        }
        /// <summary>
        /// Валидация минимального и максимального количества слов
        /// </summary>
        /// <param name="minWords">Минимально количество слов</param>
        /// <param name="maxWords">Максимально количество слов</param>
        private void ValidateMinAndMaxWords(ref int minWords, ref int maxWords)
        {
            if (minWords < 1)
            {
                minWords = 1;
            }
            if (minWords >= maxWords)
            {
                minWords = maxWords - minWords;
            }
            if (maxWords <= minWords)
            {
                maxWords = minWords + maxWords;
            }
        }
        /// <summary>
        /// Генерация таймера
        /// </summary>
        /// <param name="generatedChars">Список символов</param>
        private void GenerateTimer(List<char> generatedChars)
        {
            MaxTimer = Convert.ToInt32(generatedChars.Count * SimulatorServiceConsts.OneTimeInOneChar * SimulatorModel.Level.TimeMultiplier);
        }
    }
}
