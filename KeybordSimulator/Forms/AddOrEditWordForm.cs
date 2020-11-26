using KeybordSimulator.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Форма в которой сохдают новое слово или изменяют выбранное
    /// </summary>
    public partial class AddOrEditWordForm : Form
    {
        /// <summary>
        /// Модель для этой формы в которой содержится слово для изменения и коллекция слов
        /// </summary>
        private readonly AddOrEditWordModel _addOrEditWordModel;
        /// <summary>
        /// Булевое поле тольо для чтения, для проверки изменяем ли мы слово или нет
        /// </summary>
        private readonly bool _isEdit;
        /// <summary>
        /// Конструктор создания типа, который проихводит первоначальную инициализацию
        /// </summary>
        /// <param name="addOrEditWordModel">Модель для этой формы</param>
        public AddOrEditWordForm(AddOrEditWordModel addOrEditWordModel)
        {
            InitializeComponent();
            _addOrEditWordModel = addOrEditWordModel;
            if (_addOrEditWordModel.WordToEdit == null)
            {
                _isEdit = false;
                _addOrEditWordModel.WordToEdit = new WordModel();
            }
            else
            {
                _isEdit = true;
            }
        }
        /// <summary>
        /// Обработчик загрузки формы, тут проверяется на то, редактировать нужно слово или создавать новое и
        /// от этого изменятся UI
        /// </summary>
        private void AddOrEditWordForm_Load(object sender, EventArgs e)
        {
            _addOrEditWordModel.Words.AddingNew += Words_AddingNew;
            if (_isEdit)
            {
                Text = $"Изменить слово - {_addOrEditWordModel.WordToEdit}";
                AddOrEditWordButton.Text = "Изменить";
                WordTextBox.Text = _addOrEditWordModel.WordToEdit.Word;
            }
            else
            {
                Text = "Добавить слово";
                AddOrEditWordButton.Text = "Добавить";
            }
        }
        /// <summary>
        /// Обработчик события добавления нового слова
        /// </summary>
        private void Words_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = _addOrEditWordModel.WordToEdit;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "Изменить" или "Добавить", при которой происходит изменение слова,
        /// обновляются о нем данные или он создается в коллекции уровней
        /// </summary>
        private void AddOrEditWordButton_Click(object sender, EventArgs e)
        {
            string value = WordTextBox.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Вы не ввели слово");
                return;
            }
            if (value.Contains(' '))
            {
                MessageBox.Show("Текстовая строка содержит пробелы или вы ввели множество слов. Пожалуйста проверьте!", "Внимание...");
                return;
            }
            _addOrEditWordModel.WordToEdit.Word = WordTextBox.Text;
            if (_isEdit)
            {
                _addOrEditWordModel.Words.ResetItem(_addOrEditWordModel.Words.IndexOf(_addOrEditWordModel.WordToEdit));
            }
            else
            {
                _addOrEditWordModel.Words.AddNew();
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
        /// Обработчи события, когда происходит изменения текста в WordTextBox,
        /// необходима для уведомлния о том, что содержутся пробелы или другие слова
        /// </summary>
        private void WordTextBox_TextChanged(object sender, EventArgs e)
        {
            var value = WordTextBox.Text;
            if (value.Contains(' '))
            {
                MessageBox.Show("Текстовая строка содержит пробелы или вы ввели множество слов. Пожалуйста проверьте!", "Внимание...");
                return;
            }
        }
    }
}
