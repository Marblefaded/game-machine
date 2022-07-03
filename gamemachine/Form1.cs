namespace gamemachine
{
    public partial class Form1 : Form
    {
        int dice1 = 0;
        int dice2 = 0;
        int sum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            dice1 = rnd.Next(1,7);
            label1.Text = "" + dice1;

            dice2 = rnd.Next(1, 7);
            label2.Text = "" + dice2;

            sum = dice1 + dice2;
            label3.Text = "" + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string bet = textBox1.Text;
            int fbet = Convert.ToInt32(bet);

            if (sum < 7)
            {
                int lseven = 2 * fbet;
                label4.Text = "" + lseven;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bet = textBox1.Text;
            int fbet = Convert.ToInt32(bet);

            int eseven = 5 * fbet;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bet = textBox1.Text;
            int fbet = Convert.ToInt32(bet);

            int mseven = 2 * fbet;
        }
    }
}