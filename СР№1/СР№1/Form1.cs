namespace СР_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (sender as Button).Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            double x = 0, x1, x2;
            // Определяет наличе "." в тексте TextBox и в случаи ее наличия заменяет на ","
            if (textBox1.Text.Contains(".") || textBox2.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
            }

            if (!double.TryParse(textBox1.Text, out x1) || !double.TryParse(textBox2.Text,out x2))
            {
                label2.Text = "= ERROR!!!";
                return; // завершение работы процедуры обработчика 
            }

            switch (label1.Text[0])
                {
                    case '+':
                        x = x1 + x2;
                        break;
                     
                    case '-':
                        x = x1 - x2;
                        break;
                    
                    case '/':
                        x = x1 / x2;
                        break;
                    
                    case '*':
                        x = x1 * x2;
                        break;
                }
                label2.Text = "= " + x;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //+ на NumPad
                case Keys.Add:
                    label1.Text = "+";
                    button5_Click(sender, e);
                    break;
                
                //Сочетание Shift и "="
                case Keys.Oemplus when e.Shift:
                    label1.Text = "+";
                    button5_Click(sender, e);
                    break;

                // - на NumPad
                case Keys.Subtract:
                    label1.Text = "-";
                    button5_Click(sender, e);
                    break;


                // - на оснавной клавиатуре
                case Keys.OemMinus:
                    label1.Text = "-";
                    button5_Click(sender, e);
                    break;

                // * на NumPad
                case Keys.Multiply:
                    label1.Text = "*";
                    button5_Click(sender, e);
                    break;

                //Сочетание Shift и "8"
                case Keys.D8 when e.Shift:
                    label1.Text = "*";
                    button5_Click(sender, e);
                    break;

                // / на NumPad
                case Keys.Divide:
                    label1.Text = "/";
                    button5_Click(sender, e);
                    break;

                // / на оснавной клавиатуре
                case Keys.OemQuestion:
                    label1.Text = "/";
                    button5_Click(sender, e);
                    break;

                // = на оснавной клавиатуре
                case Keys.Oemplus when !e.Shift:
                    button5_Click(sender, e);
                    break;

            }
        }
    }
}
