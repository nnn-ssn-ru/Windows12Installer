using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form3 : Form
    {
        bool IsPassword = false;

        string password = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Visible = true;
                textBox3.Visible = true;

                IsPassword = true;
            }
            else if (checkBox1.Checked == false) 
            {
                textBox2.Visible = false;
                textBox3.Visible = false;

                IsPassword = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {



            password = textBox2.Text;


            button1.Enabled = true;



            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsPassword)
            {

            }

            else if (IsPassword) 
            {
                if (password == textBox3.Text) { }

                else { button1.Enabled = false; }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
