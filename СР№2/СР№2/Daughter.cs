using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СР_2
{
    public partial class Daughter : Form
    {
        public Daughter(int number)
        {
            InitializeComponent();
            Text = "Doc" + number.ToString();           
        }
        // Метод срабатывающий при нажатии Open, позволяющий выбрать файл для прочтения
        // и отображения его содержимого в TextBox
        // При выборе файла передает его название в заголовок

        private void openToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);// Загружается cодержимое файла в TextBox
           this.Text = Path.GetFileName(openFileDialog1.FileName); // Изменяет заголовок
        }
    }
}
