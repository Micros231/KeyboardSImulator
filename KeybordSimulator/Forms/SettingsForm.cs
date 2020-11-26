using System;
using System.Windows.Forms;
using KeybordSimulator.Models;
using KeybordSimulator.Services;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Форма Настроек
    /// </summary>
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Ивент, который вызывается при сохранении данных
        /// </summary>
        public event Action OnSave;
        /// <summary>
        /// Служба конфига, только для чтения
        /// </summary>
        private readonly ConfigService _configService;
        /// <summary>
        /// Конструктор создания типа, в котормо происходят первоначальная инициализация
        /// </summary>
        /// <param name="configService">Служба конфига</param>
        public SettingsForm(ConfigService configService)
        {
            InitializeComponent();
            _configService = configService;
            InitLevelListBox();
        }
        /// <summary>
        /// Инициализация LevelListBox
        /// </summary>
        private void InitLevelListBox()
        {
            LevelsListBox.DataSource = _configService.Config.Levels;
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии кнопки "Сохранить изменения"
        /// </summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _configService.Save();
            OnSave?.Invoke();
            Close();
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии кнопки "Отмена"
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            _configService.СleanChanges();
            Close();
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии кнопки "Добавить уровень"
        /// </summary>
        private void AddNewLevelButton_Click(object sender, EventArgs e)
        {
            var addOrEditLevelForm = new AddOrEditLevelForm(new AddOrEditLevelModel(_configService.Config.Levels));
            addOrEditLevelForm.ShowDialog();
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии кнопки "Изменить уровень"
        /// </summary>
        private void EditLevelButton_Click(object sender, EventArgs e)
        {
            var selectedLevel = LevelsListBox.SelectedItem as LevelModel;
            var addOrEditLevelForm = new AddOrEditLevelForm(new AddOrEditLevelModel(_configService.Config.Levels, selectedLevel));
            addOrEditLevelForm.ShowDialog();
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии кнопки "Удалить уровень"
        /// </summary>
        private void DeleteLevelButton_Click(object sender, EventArgs e)
        {
            var selectedLevel = LevelsListBox.SelectedItem as LevelModel;
            var result = MessageBox.Show($"Вы уверены, что хотите удалить уровень \"{selectedLevel.LevelName}\"?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _configService.Config.Levels.Remove(selectedLevel);
            }
        }
        /// <summary>
        /// Обработчи события, которое происходит при нажатии изменении индекса выбранного значения LevelsListBox
        /// </summary>
        private void LevelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditLevelButton.Enabled = true;
            DeleteLevelButton.Enabled = true;
        }
        /// <summary>
        /// Обработчик события, которое происходит при двойном нажатии на LevelsListBox, открывает форму редактирвоания выбранного уровня
        /// </summary>
        private void LevelsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LevelsListBox.SelectedItem != null)
            {
                EditLevelButton_Click(EditLevelButton, null);
            }
        }
    }
}
