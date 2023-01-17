namespace kostka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_rzuc_Click(object sender, EventArgs e)
        {
            Random rnd2 = new Random();
            Random rnd4 = new Random();
            Random rnd6 = new Random();
            Random rnd8 = new Random();
            Random rnd10 = new Random();
            Random rnd12 = new Random();
            Random rnd20 = new Random();
            Random rnd100 = new Random();

           //2
            for (int i = 0; i <= (ile_kostek_2.Value - 1); i++)
            {
                int num2 = rnd2.Next(1, 3);
             
                label1.Visible= true;
                label1.Text += num2.ToString();
                label1.Text += ", ";   
            }

            //4
            for (int i = 0; i <= (numericUpDown1.Value - 1); i++)
            {
                int num4 = rnd4.Next(1, 5);

                label4.Visible = true;
                label4.Text += num4.ToString();
                label4.Text += ", ";
            }
            
            //6
            for (int i = 0; i <= (numericUpDown2.Value - 1); i++)
            {
                int num6 = rnd6.Next(1, 7);

                label2.Visible = true;
                label2.Text += num6.ToString();
                label2.Text += ", ";
            }
            //8
            for (int i = 0; i <= (numericUpDown3.Value - 1); i++)
            {
                int num8 = rnd8.Next(1, 8);

                label3.Visible = true;
                label3.Text += num8.ToString();
                label3.Text += ", ";
            }
            //10
            for (int i = 0; i <= (numericUpDown4.Value - 1); i++)
            {
                int num10 = rnd10.Next(1, 11);

                label5.Visible = true;
                label5.Text += num10.ToString();
                label5.Text += ", ";
            }
            //12
            for (int i = 0; i <= (numericUpDown5.Value - 1); i++)
            {
                int num12 = rnd12.Next(1, 13);

                label6.Visible = true;
                label6.Text += num12.ToString();
                label6.Text += ", ";
            }
            //20
            for (int i = 0; i <= (numericUpDown6.Value - 1); i++)
            {
                int num20 = rnd20.Next(1, 21);

                label7.Visible = true;
                label7.Text += num20.ToString();
                label7.Text += ", ";
            }
            //100
            for (int i = 0; i <= (numericUpDown7.Value - 1); i++)
            {
                int num100 = rnd100.Next(1, 101);

                label8.Visible = true;
                label8.Text += num100.ToString();
                label8.Text += ", ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}