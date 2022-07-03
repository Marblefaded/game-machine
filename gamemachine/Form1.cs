namespace gamemachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int dice1 = rnd.Next(1,7);
            label1.Text = "" + dice1;

            int dice2 = rnd.Next(1, 7);
            label2.Text = "" + dice2;

            int sum = dice1 + dice2;
            label3.Text = "" + sum;
        }
    }
}