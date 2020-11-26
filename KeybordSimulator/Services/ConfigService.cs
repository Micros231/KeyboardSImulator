using System.IO;
using Newtonsoft.Json;
using KeybordSimulator.Models;
using KeybordSimulator.Shared.Paths;

namespace KeybordSimulator.Services
{
    /// <summary>
    /// Служба конфига
    /// </summary>
    public class ConfigService
    {
        /// <summary>
        /// Свойство конфига, который передает всегда клонированную версию кешированного конфига
        /// Работает по принципу, если нет клонированного конфига, то мы его создаем или
        /// если клонированный онфиг имеет ссылку на кешированный, то мы создаем копию кешированного конфига
        /// </summary>
        public ConfigModel Config
        {
            get
            {
                if (_clonedConfig == null || _clonedConfig == _cashedConfig)
                {
                    _clonedConfig = _cashedConfig.Clone();
                }
                return _clonedConfig;
            }
        }
        /// <summary>
        /// Поле в котором хранится, кешированная версия конфига
        /// </summary>
        private ConfigModel _cashedConfig;
        /// <summary>
        /// Поле в котором хранится клонировання версия конфига
        /// </summary>
        private ConfigModel _clonedConfig;
        /// <summary>
        /// Конструктор типа без параметров, 
        /// которой инициализирует работу службы и создает или получает доступный конфиг
        /// </summary>
        public ConfigService()
        {
            if (CheckExistsConfig())
            {
                var config = GetConfigInFile();
                if (config == null)
                {
                    DeleteConfig();
                    config = CreateNewConfig();
                }
                _cashedConfig = config;
            }
            else
            {
                _cashedConfig = CreateNewConfig();
            }
            Save();
        }
        
        /// <summary>
        /// Метод, сохранения конфига
        /// </summary>
        public void Save()
        {
            if (CheckExistsConfig())
            {
                using (var configStream = File.OpenWrite(Path.Combine(DirectoryPaths.Configs, FileNames.KeyboardSimulatorConfig)))
                using (var writer = new StreamWriter(configStream))
                {
                    configStream.SetLength(0);
                    configStream.Flush();
                    _cashedConfig = Config;
                    var jsonString = JsonConvert.SerializeObject(_cashedConfig);
                    writer.Write(jsonString);
                }
            }
        }
        /// <summary>
        /// Метод очитки изменений, при котором, мы присваиваем клонированной версии - кешированную
        /// </summary>
        public void СleanChanges()
        {
            _clonedConfig = _cashedConfig;
        }
        /// <summary>
        /// Мутод удаления файла конфига
        /// </summary>
        private void DeleteConfig()
        {
            File.Delete(Path.Combine(DirectoryPaths.Configs, FileNames.KeyboardSimulatorConfig));
        }
        /// <summary>
        /// Метод создание нового конфига
        /// </summary>
        /// <returns></returns>
        private ConfigModel CreateNewConfig()
        {
            var newConfig = new ConfigModel();
            if (!Directory.Exists(DirectoryPaths.Configs))
            {
                Directory.CreateDirectory(DirectoryPaths.Configs);
            }
            using (var configStream = File.Create(Path.Combine(DirectoryPaths.Configs, FileNames.KeyboardSimulatorConfig)))
            using (var writer = new StreamWriter(configStream))
            {
                var jsonString = JsonConvert.SerializeObject(newConfig);
                writer.Write(jsonString);
            }
            return newConfig;
        }
        /// <summary>
        /// Метод получения конфига из файла
        /// </summary>
        /// <returns></returns>
        private ConfigModel GetConfigInFile()
        {
            using (var configStream = File.OpenRead(Path.Combine(DirectoryPaths.Configs, FileNames.KeyboardSimulatorConfig)))
            using (var reader = new StreamReader(configStream))
            {
                var jsonString = reader.ReadToEnd();
                if (string.IsNullOrEmpty(jsonString))
                {
                    return null;
                }
                var config = JsonConvert.DeserializeObject<ConfigModel>(jsonString);
                return config;
            }
        }
        /// <summary>
        /// Проверка существования файла конфига
        /// </summary>
        /// <returns></returns>
        private bool CheckExistsConfig()
        {
            if (Directory.Exists(DirectoryPaths.Configs))
            {
                if (File.Exists(Path.Combine(DirectoryPaths.Configs, FileNames.KeyboardSimulatorConfig)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
