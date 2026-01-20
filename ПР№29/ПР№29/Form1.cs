namespace ПР_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            human.Name = textBox1.Text;
            HumanForm Man = new HumanForm(human);
            Visible = false;
            Man.ShowDialog();
            Close();
        }
    }
}
