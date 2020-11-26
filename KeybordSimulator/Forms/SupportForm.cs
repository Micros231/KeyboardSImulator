using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeybordSimulator.Forms
{
    /// <summary>
    /// Форма "Помощи"
    /// </summary>
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод, который срабатывает при нажатии кнопки "Окей"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
