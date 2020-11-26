namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель симулятора, которая используется для гененрации уровня и хранении данных выбранного уровня
    /// </summary>
    public class SimulatorModel
    {
        /// <summary>
        /// Свойство имени пользователя(тольо для чтения)
        /// </summary>
        public string UserName { get;}
        /// <summary>
        /// Свойство уровня(тольо для чтения)
        /// </summary>
        public LevelModel Level { get;}
        /// <summary>
        /// онструтор создания типа
        /// </summary>
        /// <param name="name">Имя пользователя</param>
        /// <param name="level">Модль уровня</param>
        public SimulatorModel(string name, LevelModel level)
        {
            UserName = name;
            Level = level;
        }
    }
}
