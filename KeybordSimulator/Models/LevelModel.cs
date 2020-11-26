using System.ComponentModel;
using System.Text;
using Newtonsoft.Json;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель уровня, необходима для изменения данных в конфиге и использования в симуляторе. 
    /// Имеет аттрибуты Json, для более легкой сериализации и десериализации данных
    /// </summary>
    [JsonObject]
    public class LevelModel
    {
        /// <summary>
        /// Имя уровня
        /// </summary>
        [JsonProperty]
        public string LevelName { get; set; }
        /// <summary>
        /// Множитель времени
        /// </summary>
        [JsonProperty]
        public float TimeMultiplier { get; set; }
        /// <summary>
        /// Минимально-возможное количество слов на уровне
        /// </summary>
        [JsonProperty]
        public int MinWords { get; set; }
        /// <summary>
        /// Максимально-возможное количество слов на уровне
        /// </summary>
        [JsonProperty]
        public int MaxWords { get; set; }
        /// <summary>
        /// Коллекция с возможностью привязки данных, в которой хранится список слов
        /// Нельзя присваивать из вне новый список, только добавлять или удалять элементы списка
        /// </summary>
        [JsonProperty]
        public BindingList<WordModel> Words { get; private set; }
        /// <summary>
        /// Конструктор создания типа без параметров
        /// </summary>
        public LevelModel()
        {
            Words = new BindingList<WordModel>();
        }
        /// <summary>
        /// онструтор создания типа
        /// </summary>
        /// <param name="name">Имя уровня</param>
        /// <param name="timeMultiplier">Множитель времени</param>
        public LevelModel(string name, float timeMultiplier) : this()
        {
            LevelName = name;
            TimeMultiplier = timeMultiplier;
        }

        /// <summary>
        /// Переопределение базового виртуального метода
        /// Необходимо, для представления уровней в UI списках
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Название уровня: {LevelName}; \t");
            stringBuilder.Append($"Множитель времени: {TimeMultiplier}; \t");
            stringBuilder.Append($"Количество слов: {Words.Count}; \t");

            return stringBuilder.ToString();
        }

    }
}
