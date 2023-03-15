using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_number_click(object sender, EventArgs e)
        {
            string math_sym = "+-x÷";
            string sign = (sender as Button).Text;

            bool operation = false;

            if (math_sym.Contains(sign))
            {
                operation = true;
            }

            if(tb_Top.Text == "" && operation)
            {
                tb_Top.Text = 0 + sign;
            }
            else if(tb_Top.Text != "" && operation)
            {
                tb_Top.Text += sign;
            }
            else if(tb_Bottom.Text == "0")
            {
                tb_Bottom.Text = sign;
            }
            else
            {
                tb_Bottom.Text += sign;
            }


            operation = false;
            
        }

        private void btn_backspace_click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_click(object sender, EventArgs e)
        {

        }

        private void btn_changeSign_click(object sender, EventArgs e)
        {

        }

        private void btn_equals_click(object sender, EventArgs e)
        {

        }

        private void btn_backspace_Click_1(object sender, EventArgs e)
        {

        }

        private void tb_Screen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            string input = tb_Top.Text;
            tb_Top.Text += "=";

            String[] separator = { "+", "-", "x", "÷"};

            String[] strlist = input.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
            
            float number1 = float.Parse(strlist[0]);
            float number2 = float.Parse(strlist[1]);

            tb_Bottom.Text = "";
            float answear = 0.0f;

            if (input.Contains("+"))
            {
                answear = number1 + number2;
                string answear_Output = answear.ToString();
                tb_Bottom.Text = answear_Output;
            }
            if (input.Contains("-"))
            {
                answear = number1 - number2;
                string answear_Output = answear.ToString();
                tb_Bottom.Text = answear_Output;
            }
            if (input.Contains("x"))
            {
                answear = number1 * number2;
                string answear_Output = answear.ToString();
                tb_Bottom.Text = answear_Output;
            }
            if (input.Contains("÷"))
            {
                if (number2 == 0)
                {
                    tb_Bottom.Text = "Nie można dzielić przez zero";

                }
                else
                {
                    answear = number1 / number2;
                    string answear_Output = answear.ToString();
                    tb_Bottom.Text = answear_Output;
                }
            }
            tb_Top.Text = "";


        }
    }
}
