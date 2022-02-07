namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        //Numeronäppäimet
        private void button2_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 0 + 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int c = Naytto.TextLength;
            int flag = 0;
            string text = Naytto.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                Naytto.Text = Naytto.Text + ".";
            }
        }

        //Toimintanäppäimet
        private void button_clear_Click(object sender, EventArgs e)
        {
            Naytto.Clear();
            count = 0;
        }

        private void button_divice_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Naytto.Text);
            Naytto.Clear();
            Naytto.Focus();
            count = 4;
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Naytto.Text);
            Naytto.Clear();
            Naytto.Focus();
            count = 3;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(Naytto.Text);
            Naytto.Clear();
            Naytto.Focus();
            count = 2;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (Naytto.Text != "")
            {
                num1 = float.Parse(Naytto.Text);
                Naytto.Clear();
                Naytto.Focus();
                count = 1;
            }
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(Naytto.Text);
                    Naytto.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(Naytto.Text);
                    Naytto.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(Naytto.Text);
                    Naytto.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(Naytto.Text);
                    Naytto.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Naytto.Text = Naytto.Text + 7;
        }
    }
}