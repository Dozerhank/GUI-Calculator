using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Solver user = new Solver();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user.display[0] = "";
            user.display[1] = "------------------";
            user.display[2] = "";
            user.ClearHistory();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Clear();
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.Accumulate("-");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user.display[0] == "")
            {
                user.Accumulate(user.previous + "%");
            }
            else
            {
                user.Accumulate("%");
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (user.display[0] == "")
            {
                user.Accumulate(user.previous + "/");
            }
            else
            {
                user.Accumulate("/");
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            user.Accumulate("1");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            user.Accumulate("2");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            user.Accumulate("3");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (user.display[0] == "")
            {
                user.Accumulate(user.previous + "+");
            }
            else
            {
                user.Accumulate("+");
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            user.Accumulate("4");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            user.Accumulate("5");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            user.Accumulate("6");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (user.display[0] == "")
            {
                user.Accumulate(user.previous + "-");
            }
            else
            {
                user.Accumulate("-");
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            user.Accumulate("7");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            user.Accumulate("8");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            user.Accumulate("9");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (user.display[0] == "")
            {
                user.Accumulate(user.previous + "*");
            }
            else
            {
                user.Accumulate("*");
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            user.Accumulate("0");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            user.Accumulate(".");
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            user.display[2] = Convert.ToString(user.Solve(user.display[0]));
            if (Convert.ToString(user.display[2]) == "∞")
            {
                user.display[2] = "error";
            }
            textBox1.Lines = user.display;
            textBox2.Lines = user.history;

            user.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            user.ClearHistory();
            textBox2.Lines = user.history;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (user.darkMode == false)
            {
                this.BackColor = Color.Black;
                button1.BackColor = Color.DarkSlateGray;
                button2.BackColor = Color.DarkSlateGray;
                button3.BackColor = Color.DarkSlateGray;
                button4.BackColor = Color.DarkSlateGray;
                button5.BackColor = Color.DarkSlateGray;
                button6.BackColor = Color.DarkSlateGray;
                button7.BackColor = Color.DarkSlateGray;
                button8.BackColor = Color.DarkSlateGray;
                button9.BackColor = Color.DarkSlateGray;
                button10.BackColor = Color.DarkSlateGray;
                button11.BackColor = Color.DarkSlateGray;
                button12.BackColor = Color.DarkSlateGray;
                button13.BackColor = Color.DarkSlateGray;
                button14.BackColor = Color.DarkSlateGray;
                button15.BackColor = Color.DarkSlateGray;
                button16.BackColor = Color.DarkSlateGray;
                button17.BackColor = Color.DarkSlateGray;
                button18.BackColor = Color.DarkSlateGray;
                button19.BackColor = Color.DarkSlateGray;
                button20.BackColor = Color.DarkSlateGray;
                button21.BackColor = Color.DarkSlateGray;
                button22.BackColor = Color.DarkSlateGray;
                button23.BackColor = Color.DarkSlateGray;
                textBox1.BackColor = Color.DarkGray;
                textBox2.BackColor = Color.DarkGray;

                button1.ForeColor = Color.FloralWhite;
                button2.ForeColor = Color.FloralWhite;
                button3.ForeColor = Color.FloralWhite;
                button4.ForeColor = Color.FloralWhite;
                button5.ForeColor = Color.FloralWhite;
                button6.ForeColor = Color.FloralWhite;
                button7.ForeColor = Color.FloralWhite;
                button8.ForeColor = Color.FloralWhite;
                button9.ForeColor = Color.FloralWhite;
                button10.ForeColor = Color.FloralWhite;
                button11.ForeColor = Color.FloralWhite;
                button12.ForeColor = Color.FloralWhite;
                button13.ForeColor = Color.FloralWhite;
                button14.ForeColor = Color.FloralWhite;
                button15.ForeColor = Color.FloralWhite;
                button16.ForeColor = Color.FloralWhite;
                button17.ForeColor = Color.FloralWhite;
                button18.ForeColor = Color.FloralWhite;
                button19.ForeColor = Color.FloralWhite;
                button20.ForeColor = Color.FloralWhite;
                button21.ForeColor = Color.FloralWhite;
                button22.ForeColor = Color.FloralWhite;
                button23.ForeColor = Color.FloralWhite;

                user.darkMode = true;
                button21.Text = "Light Mode";
            }
            else
            {
                this.BackColor = Color.White;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button3.BackColor = Color.White;
                button4.BackColor = Color.White;
                button5.BackColor = Color.White;
                button6.BackColor = Color.White;
                button7.BackColor = Color.White;
                button8.BackColor = Color.White;
                button9.BackColor = Color.White;
                button10.BackColor = Color.White;
                button11.BackColor = Color.White;
                button12.BackColor = Color.White;
                button13.BackColor = Color.White;
                button14.BackColor = Color.White;
                button15.BackColor = Color.White;
                button16.BackColor = Color.White;
                button17.BackColor = Color.White;
                button18.BackColor = Color.White;
                button19.BackColor = Color.White;
                button20.BackColor = Color.White;
                button21.BackColor = Color.White;
                button22.BackColor = Color.White;
                button23.BackColor = Color.White;
                textBox1.BackColor = Color.FloralWhite;
                textBox2.BackColor = Color.FloralWhite;

                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                button7.ForeColor = Color.Black;
                button8.ForeColor = Color.Black;
                button9.ForeColor = Color.Black;
                button10.ForeColor = Color.Black;
                button11.ForeColor = Color.Black;
                button12.ForeColor = Color.Black;
                button13.ForeColor = Color.Black;
                button14.ForeColor = Color.Black;
                button15.ForeColor = Color.Black;
                button16.ForeColor = Color.Black;
                button17.ForeColor = Color.Black;
                button18.ForeColor = Color.Black;
                button19.ForeColor = Color.Black;
                button20.ForeColor = Color.Black;
                button21.ForeColor = Color.Black;
                button22.ForeColor = Color.Black;
                button23.ForeColor = Color.Black;

                user.darkMode = false;
                button21.Text = "Dark Mode";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string temp = user.display[0];
            if (temp != "")
            {
                temp = temp.Remove(temp.Length - 1);
            }
            user.display[0] = temp;
            textBox1.Lines = user.display;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //Save file
        }
    }
}