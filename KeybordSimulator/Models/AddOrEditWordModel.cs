using KeybordSimulator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeybordSimulator.Models
{
    /// <summary>
    /// Модель для добавления или изменения слова
    /// </summary>
    public class AddOrEditWordModel
    {
        /// <summary>
        /// Коллекция с возможностью привязки данных, в которой хранится список слов(тольо для чтения)
        /// </summary>
        public BindingList<WordModel> Words { get; }
        /// <summary>
        /// Слово для изменения
        /// </summary>
        public WordModel WordToEdit { get; set; }
        /// <summary>
        /// Конструктор создания типа
        /// </summary>
        /// <param name="words">Список слов</param>
        public AddOrEditWordModel(BindingList<WordModel> words)
        {
            Words = words;
        }
        /// <summary>
        /// Конструтор создания типа
        /// </summary>
        /// <param name="words">Список слов</param>
        /// <param name="worldToEdit">Слово для изменения</param>
        public AddOrEditWordModel(BindingList<WordModel> words, WordModel worldToEdit) : this(words)
        {
            WordToEdit = worldToEdit;
        }
    }
}
