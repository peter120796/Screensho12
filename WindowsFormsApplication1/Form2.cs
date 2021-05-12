using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            if (fname.Equals("first name"))
            {
                textBox1.Text = " "; 
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            string lname = textBox7.Text;
            if (lname.Equals("last name"))
            {
                textBox7.Text = " ";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            string emil = textBox4.Text;
            if (emil.Equals("email address"))
            {
                textBox4.Text = " ";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            string usr = textBox5.Text;
            if (usr.Equals("user name"))
            {
                textBox5.Text = " ";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            string pass = textBox8.Text;
            if (pass.Equals("password"))
            {
                textBox8.Text = " ";
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            string cnfrm = textBox9.Text;
            if (cnfrm.Equals("confirm password"))
            {
                textBox9.Text = " ";
            }
        }

        
    }
}
