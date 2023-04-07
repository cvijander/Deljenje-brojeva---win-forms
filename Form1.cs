namespace Drugi__bolji_nacin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sa2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 2; i <= 30; i += 2)
            {
                richTextBox1.Text += i + "\n";
            }
        }

        private void Sa5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 5; i <= 30; i += 5)
            {
                richTextBox1.Text += i + "\n";
            }
        }

        private void Sa7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 7; i <= 30; i += 7)
            {
                richTextBox1.Text += i + "\n";
            }
        }

        private void sa11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 11; i <= 30; i += 11)
            {
                richTextBox1.Text += i + "\n";
            }
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}