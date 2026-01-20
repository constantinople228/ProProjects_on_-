using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ПР_29
{
    public partial class HumanForm : Form
    {
        Human man = new Human();
        public HumanForm(Human human)
        {
            InitializeComponent();
            man = human;
            man.Mood = 10;
            man.Satiety = 10;
            man.Iq = 10;
            label1.Text = "Имя " + man.Name;
            label2.Text = "Настроение " + man.Mood;
            label3.Text = "Сытость " + man.Satiety;
            label4.Text = "Iq " + man.Iq;
        }
        void button1_Click(object sender, EventArgs e)
        {
            man.Eat();
            label2.Text = "Настроение " + man.Mood;
            label3.Text = "Сытость " + man.Satiety;
            label4.Text = "Iq " + man.Iq;
        }

        void button2_Click(object sender, EventArgs e)
        {
            man.Relax();
            label2.Text = "Настроение " + man.Mood;
            label3.Text = "Сытость " + man.Satiety;
            label4.Text = "Iq " + man.Iq;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            man.Work();
            label2.Text = "Настроение " + man.Mood;
            label3.Text = "Сытость " + man.Satiety;
            label4.Text = "Iq " + man.Iq;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            man.Leran();
            label2.Text = "Настроение " + man.Mood;
            label3.Text = "Сытость " + man.Satiety;
            label4.Text = "Iq " + man.Iq;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            man.Mood -= 1;
            label2.Text = "Настроение " + man.Mood;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            man.Satiety -= 1;
            label3.Text = "Сытость " + man.Satiety;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            man.Iq -= 1;
            label4.Text = "Iq " + man.Iq;
        }
    }
}
