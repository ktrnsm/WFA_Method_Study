using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Method_Study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModifyTheControllers();

        }

        private void ModifyTheControllers()
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                    item.BackColor = Color.Red;
                else if (item is CheckBox)
                {
                    (item as CheckBox).Checked = true;
                }
                else if (item is ListBox)
                {
                    (item as ListBox).Items.Add("Hello World");
                }
                else if (item is GroupBox)
                {
                    foreach (Control subitem in item.Controls)
                    {
                        if (subitem is Button)
                        {
                            subitem.BackColor = Color.Red;
                        }
                        else if (subitem is CheckBox)
                        {
                            (subitem as CheckBox).Checked = true;
                        }

                    }

                }


            }
        }

        int firstNum, output, lastNum1;

        private void TypeFibo( int numb)
        {
            label1.Text = "";
            int numCounter = Convert.ToInt32(textBox1.Text);

            while (numCounter > 0)
                label1.Text += $"{firstNum}";
            output = firstNum + lastNum1;
            firstNum = lastNum1;
            lastNum1 = output;
            numCounter--;

            label1.Text = listBox1.Text.Trim('-');
            firstNum = 0;
            output = 0;
            lastNum1 = 1;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            TypeFibo(Convert.ToInt32(textBox1.Text));
        }
    }
}
