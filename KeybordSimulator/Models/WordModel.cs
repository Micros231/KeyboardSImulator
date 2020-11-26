using Newtonsoft.Json;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель слова, необходима для изменения данных в конфиге и использования в симуляторе. 
    /// Имеет аттрибуты Json, для более легкой сериализации и десериализации данных
    /// </summary>
    [JsonObject]
    public class WordModel
    {
        /// <summary>
        /// Свойство слова
        /// </summary>
        [JsonProperty]
        public string Word { get; set; }
    }
}
