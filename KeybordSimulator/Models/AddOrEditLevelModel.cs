using System.ComponentModel;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель создания или изменения уровня
    /// </summary>
    public class AddOrEditLevelModel
    {
        /// <summary>
        /// Коллекция с возможностью привязки данных в которой хранится список уровней(тольо для чтения)
        /// </summary>
        public BindingList<LevelModel> Levels { get; }
        /// <summary>
        /// Модель уровня, чтобы изменять его
        /// </summary>
        public LevelModel LevelToEdit { get; set; }

        /// <summary>
        /// Конструктор создания типа
        /// </summary>
        /// <param name="levels">Список левелов</param>
        public AddOrEditLevelModel(BindingList<LevelModel> levels)
        {
            Levels = levels;
        }
        /// <summary>
        /// Конструктор создания типа
        /// </summary>
        /// <param name="levels">Список левелов</param>
        /// <param name="level">Модель уровня для изменения</param>
        public AddOrEditLevelModel(BindingList<LevelModel> levels, LevelModel level) : this(levels)
        {
            LevelToEdit = level;
        }
    }
}
