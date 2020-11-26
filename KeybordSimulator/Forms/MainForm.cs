using System;
using System.Windows.Forms;
using KeybordSimulator.Models;
using KeybordSimulator.Services;
using KeybordSimulator.Shared.UI;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле только для чтения со службой конфига
        /// </summary>
        private readonly ConfigService _configService;
        /// <summary>
        /// Булевое поле только для чтения, которое нужно для проверки на то, произошла ли инциализиция или нет
        /// </summary>
        private readonly bool _isInitComplete;
        /// <summary>
        /// Конструктор создания типа, в котором создается слуюжа конфига, атакже происходят инициализации
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _configService = new ConfigService();
            InitLevelComboBox();
            InitNameTextBox();
            _isInitComplete = true;
        }
        /// <summary>
        /// Инициализация LevelComboBox, необходим для возможности выбора уровня
        /// </summary>
        private void InitLevelComboBox()
        {
            LevelComboBox.DataSource = _configService.Config.Levels;
            LevelComboBox.DisplayMember = "LevelName";
            LevelComboBox.ValueMember = "LevelName";
            if (_configService.Config.LastLevel != null && _configService.Config.Levels.Count > 0)
            {
                LevelComboBox.SelectedIndex = LevelComboBox.FindStringExact(_configService.Config.LastLevel.LevelName); 
            }

        }
        /// <summary>
        /// Инициализация NameTextBox, необходим для возможности изменения имени
        /// </summary>
        private void InitNameTextBox()
        {
            if (string.IsNullOrEmpty(_configService.Config.UserName))
            {
                NameTextBox.Text = UIControlConsts.NameTextBoxPlaceholder;
            }
            else
            {
                NameTextBox.Text = _configService.Config.UserName;
            }
            NameTextBox.GotFocus += NameTextBox_GotFocus;
            NameTextBox.LostFocus += NameTextBox_LostFocus;
        }
        /// <summary>
        /// Обработчик события нажатия конпки "Запуска тренировки",
        /// который или начинает тренировку или оповешает о том, что чего-то не хватает для заупска
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (CheckIsValidStartLevel())
            {
                var simulatorForm = new SimulatorForm(
                new SimulatorModel(_configService.Config.UserName, _configService.Config.LastLevel));
                simulatorForm.ShowDialog();
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Настройки",
        /// который открывает форму Настроек
        /// </summary>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm(_configService);
            settingsForm.OnSave += SettingsForm_OnSave;
            settingsForm.ShowDialog();
            settingsForm.OnSave -= SettingsForm_OnSave;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Помощь",
        /// который открывает форму Помощь
        /// </summary>
        private void SupportButton_Click(object sender, EventArgs e)
        {
            var supportForm = new SupportForm();
            supportForm.ShowDialog();
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Выход",
        /// Закрывает приложение
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Обработчик события изменения индекса, при выборе Уровня в LevelComboBox,
        /// позволяет как раз таки узнать, что мы выбрали и установить это в LastLevel
        /// </summary>
        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitComplete)
            {
                return;
            }
            var selectedLevel = LevelComboBox.SelectedItem as LevelModel;
            if (selectedLevel != null)
            {
                _configService.Config.LastLevel = selectedLevel;
            }
            
        }
        /// <summary>
        /// Обработчик события изменения текстового значения NameTextBox
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                var userName = NameTextBox.Text;
                _configService.Config.UserName = userName;
            }
        }
        /// <summary>
        /// Обработчик события входа в фокус NameTextBox, необходим для имитации Placeholder из Web
        /// </summary>
        private void NameTextBox_GotFocus(object sender, EventArgs e)
        {
            if (NameTextBox.Text == UIControlConsts.NameTextBoxPlaceholder)
            {
                NameTextBox.Text = string.Empty;
            }
        }
        /// <summary>
        /// Обработчик события выхода из фокуса NameTextBox, необходим для имитации Placeholder из Web
        /// </summary>
        private void NameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                NameTextBox.Text = UIControlConsts.NameTextBoxPlaceholder;
            }
        }
        /// <summary>
        /// Обработчик события, когда форма закрылась, тут происходит отписка от всех ивентов, а также сохранения конфига
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NameTextBox.GotFocus -= NameTextBox_GotFocus;
            NameTextBox.LostFocus -= NameTextBox_LostFocus;
            if (LevelComboBox.Items.Count == 0)
            {
                _configService.Config.LastLevel = null;
            }
            _configService.Save();
        }
        /// <summary>
        /// Обработчик события, который происходит, когда в форме Натроек происходит сохранения конфига, 
        /// необходимо для обновления данных LevelComboBox в этой форме
        /// </summary>
        private void SettingsForm_OnSave()
        {
            InitLevelComboBox();
            LevelComboBox.Update();
        }
        /// <summary>
        /// Проверка на то получится ли у нас запустить уровень или нет и вывод сообщений
        /// с тем чего не хватает
        /// </summary>
        /// <returns></returns>
        private bool CheckIsValidStartLevel()
        {
            if (LevelComboBox.Items.Count == 0)
            {
                MessageBox.Show("Создайте и выберите уровень!");
                return false;
            }
            if (_configService.Config.LastLevel.Words.Count == 0)
            {
                MessageBox.Show("Выбранный уровень содержит 0 слов!");
                return false;
            }
            if (string.IsNullOrEmpty(_configService.Config.UserName) || 
                _configService.Config.UserName == UIControlConsts.NameTextBoxPlaceholder)
            {
                MessageBox.Show("Вы не ввели имя!");
                return false;
            }
            return true;
        }
    }
}
