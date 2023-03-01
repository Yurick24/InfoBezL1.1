using System.Diagnostics.SymbolStore;

namespace InfBez_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;
            bool symbol1 = checkBox1.Checked;
            bool symbol2 = checkBox2.Checked;
            bool symbol3 = checkBox3.Checked;
            bool symbol4 = checkBox4.Checked;
            Random random = new Random();
            for (int j = 0; j < quantity; j++)
            {
                for (int i = 0; i < length; i++)
                {
                    int f = random.Next(0, 4);

                    if (symbol1 == true && f == 0)
                    {
                        int value = (int)random.Next(0, 9);
                        richTextBox1.AppendText(value.ToString());
                    }
                    else if (symbol2 == true && f == 1)
                    {
                        char value = (char)random.Next(65, 91);
                        richTextBox1.AppendText(value.ToString());
                    }
                    else if (symbol3 == true && f == 2)
                    {
                        char value = (char)random.Next(33, 46);
                        richTextBox1.AppendText(value.ToString());
                    }
                    else if (symbol4 == true && f == 3)
                    {
                        char value = (char)random.Next(97, 123);
                        richTextBox1.AppendText(value.ToString());
                    }
                    else
                    {
                        i--;
                    }
                }
                richTextBox1.AppendText("\n");
                //
            }
        }
    }
}