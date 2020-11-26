using KeybordSimulator.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Форма в которой создают новый уровень или изменяют выбранный
    /// </summary>
    public partial class AddOrEditLevelForm : Form
    {
        /// <summary>
        /// Булевое поле тольо для чтения, для проверки изменяем ли мы уровень или нет
        /// </summary>
        private readonly bool _isEdit;
        /// <summary>
        /// Модель для этой формы в которой содержится уровень для изменения и коллекция уровней
        /// </summary>
        private readonly AddOrEditLevelModel _addOrEditLevel;
        /// <summary>
        /// Конструктор создания типа, который проихводит первоначальную инициализацию
        /// </summary>
        /// <param name="addOrEditLevel">Модель для этой формы</param>
        public AddOrEditLevelForm(AddOrEditLevelModel addOrEditLevel)
        {
            InitializeComponent();
            _addOrEditLevel = addOrEditLevel;
            _addOrEditLevel.Levels.AddingNew += Levels_AddingNew;
            if (_addOrEditLevel.LevelToEdit == null)
            {
                _isEdit = false;
                _addOrEditLevel.LevelToEdit = new LevelModel();
            }
            else
            {
                _isEdit = true;
            }
            InitWordsListBox();
            InitMinMaxWordsNumeric();
        }
        /// <summary>
        /// Инициализация MaxWordsNumeric и MinWordsNumeric на максимально и минимальное доступное значение
        /// </summary>
        private void InitMinMaxWordsNumeric()
        {
            MaxWordsNumeric.Maximum = decimal.MaxValue;
            MaxWordsNumeric.Minimum = 1;
            MinWordsNumeric.Maximum = decimal.MaxValue;
            MinWordsNumeric.Minimum = 1;
        }
        /// <summary>
        /// Инициализация WordsListBox, в котором содержится списо слов на уровне
        /// </summary>
        private void InitWordsListBox()
        {
            WordsListBox.DataSource = _addOrEditLevel.LevelToEdit.Words;
            WordsListBox.DisplayMember = "Word";
        }
        /// <summary>
        /// Обработчик загрузки формы, тут проверяется на то, редактировать нужно уровень или создавать новый и
        /// от этого изменятся UI
        /// </summary>
        private void AddOrEditLevelForm_Load(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                Text = $"Изменить уровень - {_addOrEditLevel.LevelToEdit.LevelName}";
                AddAndEditButton.Text = "Изменить";
                LevelNameTextBox.Text = _addOrEditLevel.LevelToEdit.LevelName;
                TimeMultiplierNumeric.Value = Convert.ToDecimal(_addOrEditLevel.LevelToEdit.TimeMultiplier);
                MaxWordsNumeric.Value = Convert.ToDecimal(_addOrEditLevel.LevelToEdit.MaxWords);
                MinWordsNumeric.Value = Convert.ToDecimal(_addOrEditLevel.LevelToEdit.MinWords);
            }
            else
            {
                Text = "Добавить новый уровень";
                AddAndEditButton.Text = "Добавить";
            }
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Изменить" или "Добавить", при которой происходит изменение значений уровня,
        /// обновляются о нем данные или он создается в коллекции уровней
        /// </summary>
        private void AddAndEditButton_Click(object sender, EventArgs e)
        {
            _addOrEditLevel.LevelToEdit.LevelName = LevelNameTextBox.Text;
            _addOrEditLevel.LevelToEdit.TimeMultiplier = (float)Convert.ToDouble(TimeMultiplierNumeric.Value);
            _addOrEditLevel.LevelToEdit.MaxWords = Convert.ToInt32(MaxWordsNumeric.Value);
            _addOrEditLevel.LevelToEdit.MinWords = Convert.ToInt32(MinWordsNumeric.Value);
            if (_isEdit)
            {
                _addOrEditLevel.Levels.ResetItem(_addOrEditLevel.Levels.IndexOf(_addOrEditLevel.LevelToEdit));
            }
            else
            {
                _addOrEditLevel.Levels.AddNew();
            }
            Close();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Назад", закрывает форму
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Добавить слово", открывает форму добавления слова
        /// </summary>
        private void AddWord_Click(object sender, EventArgs e)
        {
            var addOrEditWordForm = new AddOrEditWordForm(new AddOrEditWordModel(_addOrEditLevel.LevelToEdit.Words));
            addOrEditWordForm.Show();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Изменить слово", открывает форму изменения слова
        /// </summary>
        private void EditWord_Click(object sender, EventArgs e)
        {
            var selectedWord = WordsListBox.SelectedItem as WordModel;
            var addOrEditWordForm = new AddOrEditWordForm(new AddOrEditWordModel(_addOrEditLevel.LevelToEdit.Words, selectedWord));
            addOrEditWordForm.Show();
        }
        /// <summary>
        /// Обработчик нажатия кнопки "Удалить слово", удаляет выбранное слово
        /// </summary>
        private void DeleteWord_Click(object sender, EventArgs e)
        {
            var selectedWord = WordsListBox.SelectedItem as WordModel;
            var result = MessageBox.Show($"Вы уверены, что хотите удалить слово \"{selectedWord.Word}\"?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _addOrEditLevel.LevelToEdit.Words.Remove(selectedWord);
            }
        }
        /// <summary>
        /// Обработчик события изменения индекса выбранного слова в WordsListBox
        /// </summary>
        private void WordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteWordButton.Enabled = true;
            EditWordButton.Enabled = true;
        }
        /// <summary>
        /// Обработчик события двойного нажатия по WordsListBox, открывает выбранное слово для редактирования
        /// </summary>
        private void WordsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WordsListBox.SelectedItem != null)
            {
                EditWord_Click(EditWordButton, null);
            }
        }
        /// <summary>
        /// Обработчик события добавления нового уровня
        /// </summary>
        private void Levels_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = _addOrEditLevel.LevelToEdit;
        }
        /// <summary>
        /// Обработчик события изменения значения MaxWordsNumeric, нужен, 
        /// чтобы валидировать значения, чтобы оно не выходило за рамки MinWordsNumeric
        /// </summary>
        private void MaxWordsNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (MaxWordsNumeric.Value <= MinWordsNumeric.Value )
            {
                MaxWordsNumeric.Value++;
            }
        }
        /// <summary>
        /// Обработчик события изменения значения MinWordsNumeric, нужен, 
        /// чтобы валидировать значения, чтобы оно не выходило за рамки MaxWordsNumeric
        /// </summary>
        private void MinWordsNumeric_ValueChanged(object sender, EventArgs e)
        {
            if (MinWordsNumeric.Value >= MaxWordsNumeric.Value)
            {
                MinWordsNumeric.Value--;
            }
        }
    }
}
