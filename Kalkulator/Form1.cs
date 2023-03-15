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
            string sign = (sender as Button).Text;

            if(tb_Screen.Text == "0")
            {
                tb_Screen.Text = sign;
            }
            else
            {
                tb_Screen.Text += sign;
            }
            
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
    }
}
