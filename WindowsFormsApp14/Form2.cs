using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDownload
{
    public partial class Form2 : Form
    {
        public bool Confirm = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Confirm = true;

            Close();
        }
    }
}
