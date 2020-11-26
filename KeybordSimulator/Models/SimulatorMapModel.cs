using System.Collections.Generic;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель карты симулятора
    /// </summary>
    public class SimulatorMapModel
    {
        /// <summary>
        /// Свойство коллекции только для чтения, без возможности добавления или удаления элементов в которой список необходимых символов
        /// </summary>
        public IReadOnlyList<char> NeedChars { get; }
        /// <summary>
        /// Свойство коллекции в которой хранится список правильных символов(только для чтения)
        /// </summary>
        public List<char> CompleteChars { get; }
        /// <summary>
        /// Свойство коллекции в которой хранится список нахатых символов(только для чтения)
        /// </summary>
        public List<char> PressedChars { get; }
        /// <summary>
        /// Количество слов
        /// </summary>
        public int CountWords { get; set; }
        /// <summary>
        /// Количество успешно-написанных слов
        /// </summary>
        public int CompleteCountWords { get; set; }
        /// <summary>
        /// Нынешний индекс символа
        /// </summary>
        public int CurrentIndex { get; set; }
        /// <summary>
        /// Индекс, где произошла ошибка
        /// </summary>
        public int ErrorIndex { get; set; }
        /// <summary>
        /// Булевая, на проверку, имеется ли оишбка или нет
        /// </summary>
        public bool IsError { get; set; }
        /// <summary>
        /// Конструктор создания типа
        /// </summary>
        /// <param name="needChars">Перечеслитель необходимых символов</param>
        public SimulatorMapModel(IEnumerable<char> needChars)
        {
            NeedChars = new List<char>(needChars);
            CompleteChars = new List<char>();
            PressedChars = new List<char>();
        }
    }
}
