using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель конфига, необходима для изменения данных конфига.
    /// Имеет аттрибуты Json, для более легкой сериализации и десериализации данных
    /// </summary>
    [JsonObject]
    public class ConfigModel
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        [JsonProperty]
        public string UserName { get; set; }
        /// <summary>
        /// Последний уровень, который выбрал пользователь 
        /// </summary>
        [JsonProperty]
        public LevelModel LastLevel { get; set; }
        /// <summary>
        /// Коллекция с возможностью привязки данных, в которой хранится список уровней
        /// Нельзя присваивать из вне новый список, только добавлять или удалять элементы списка
        /// </summary>
        [JsonProperty]
        public BindingList<LevelModel> Levels { get; private set; }
        /// <summary>
        /// Конструтор создания типа
        /// </summary>
        public ConfigModel()
        {
            Levels = new BindingList<LevelModel>();
        }
        /// <summary>
        /// Реализация шаблона проектирования Прототип, необходим, \
        /// чтобы была возможность создать новый объект - полную копию старого
        /// а после изменять его. Использования этого паттерна, позволило создать систему принятия сделанных изменений
        /// </summary>
        /// <returns>Клон объекта, который не имеет ссылку на своего пародителя</returns>
        public ConfigModel Clone()
        {
            var cloneConfig = new ConfigModel();
            cloneConfig.UserName = UserName;
            cloneConfig.LastLevel = LastLevel;
            IList<LevelModel> clonedLevels = new List<LevelModel>(Levels);
            cloneConfig.Levels = new BindingList<LevelModel>(clonedLevels);
            return cloneConfig;
        }

    }
}
