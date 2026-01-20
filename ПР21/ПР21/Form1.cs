using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ПР21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color clr1 = Color.Black;
            Color clr2 = Color.Black;
            int i = 1;
           
            try
            {
                i = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод, строим толшиной в 1 пиксель");
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0: clr1 = Color.Red; break;
                case 1: clr1 = Color.Green; break;
                case 2: clr1 = Color.Yellow; break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0: clr2 = Color.Red; break;
                case 1: clr2 = Color.Green; break;
                case 2: clr2 = Color.Yellow; break;
            }
            Graphics g = this.CreateGraphics();
            Pen pn = new Pen(clr1, i);
            Brush br = new SolidBrush(clr2);
            g.Clear(SystemColors.Control);
            if (radioButton1.Checked)
            {
                g.DrawEllipse(pn, 95, 155, 100, 100);
                g.FillEllipse(br, 95, 155, 100, 100);
            }
            else if (radioButton2.Checked) 
            {
                g.DrawRectangle(pn, 95, 155, 100, 100);
                g.FillRectangle(br, 95, 155, 100, 100);
            }
        }
    }
}
