namespace СР_2
{
    public partial class Form1 : Form
    {
        int lastNum = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Daughter d = new Daughter(lastNum); // вызов конструктора с параметром 
            lastNum++; // увеличение номера на единицу 
            d.MdiParent = this; // "родитель" - главное окно 
            d.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren) // закрыть каждый экземпляр 
                f.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0) // если есть открытые дочерние окна, 
                this.ActiveMdiChild.Close(); // то закрыть активное дочернее окно 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это модальное окно!!!");
        }
    }
}
