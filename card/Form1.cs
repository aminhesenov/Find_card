using System;

namespace card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
        string a, b;
        int a1, b1;
        private void button5_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            string a = textBox1.Text;
            if (a == "A" || a == "K" || a == "Q" || a == "J")
            {
                if (a == "A") a1 = 1;
                if (a == "K") a1 = 2;
                if (a == "Q") a1 = 3;
                if (a == "J") a1 = 4;
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Kart doğru deyil");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            string b = textBox2.Text;
            if (b == "A" || b == "K" || b == "Q" || b == "J")
            {
                if (b == "A") b1 = 1;
                if (b == "K") b1 = 2;
                if (b == "Q") b1 = 3;
                if (b == "J") b1 = 4;
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Kart doğru deyil");
            }

        }
        int count1 = 0, count2 = 0, g1 = 0, g2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\A kart.png";
            }
            else if (num == 2)
            {
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\K kart.png";
            }
            else if (num == 3)
            {
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\Q kart.png";
            }
            else if (num == 4)
            {
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\J kart.png";
            }


            //gamer1
            if (num == a1)
            {
                count1++;
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\true.png";
            }
            else
            {
                if (count1 != 0)
                    count1--;
                pictureBox5.ImageLocation = "D:\\ASP.NET\\img\\false.png";
            }
            label15.Text = count1.ToString();


            //gamer 2
            if (num == b1)
            {
                count2++;
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\true.png";
            }
            else
            {
                if (count2 != 0)
                    count2--;
                pictureBox6.ImageLocation = "D:\\ASP.NET\\img\\false.png";
            }
            label16.Text = count2.ToString();

            if (count1 == 10)
            {
                MessageBox.Show("Oyun bitdi, oyunun qalibi (Oyunçu 1)");
                Close();
            }
            else if (count2 == 10)
            {
                MessageBox.Show("Oyun bitdi, oyunun qalibi (Oyunçu 2)");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        bool p = false;
        private void button2_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            num = r.Next(1, 5);
            if (p == false)
            {
                p = true;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\question cub.png";
            }
            else
            {
                p = false;
                pictureBox1.ImageLocation = "D:\\ASP.NET\\img\\question cub.png";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }
    }
}
