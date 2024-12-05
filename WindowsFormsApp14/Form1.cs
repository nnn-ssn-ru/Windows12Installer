using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsDownload
{

    public partial class Form1 : Form
    {

        public bool Confirm = false;

        bool list1 = true;
        bool list2 = false;
        bool list3 = false;
        bool list4 = false;
        bool list5 = false;
        bool list6 = false;



        public Form1()
        {
            InitializeComponent();

            
        }

        public void list3Start()
        {

            list2 = false;

            if (list2 != true)
            {

                label1.Text = "Дополнительные настройки";

                list3 = true;

                comboBox1.Visible = false;
                comboBox2.Visible = false;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;

                button1.Visible = true;

            }

            else { list4Start(); }


        }

        public void Download()
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                label2.Text = "Пожалуйста, выбирите значения!";

                label2.Location = new Point(234, 323);


                label2.Visible = true;
                timer1.Enabled = true;


            }
            else if (comboBox1.SelectedItem != null || comboBox2.SelectedItem != null)
            { list3Start();  }

            else if (Confirm == true) 
            {



                list4Start();

            }

        }

        public void DownloadStart() 
        {
            timer2.Enabled = true;
            timer2.Interval = 100;







        }


        public void DownloadStop()
        {
            
            
            MessageBox.Show("Успешная загрузка");
            this.Close();




        }

        public void list4Start()
        {

            list3 = false;

            if (list3 != true)
            {

                label1.Text = "Загрузка";

                list4 = true;

                label1.Location = new Point(350, 9);

                comboBox1.Visible = false;
                comboBox2.Visible = false;


                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                checkBox7.Visible = false;

                button1.Visible = false;

                button1.Visible = true;

                progressBar2.Visible = true;
                label3.Visible = true;

                DownloadStart();




            }
            

        }

       

        public void list2Start() 
        { 

            if (list1 != true) 
            {
                list2 = true;

                comboBox1.Visible = true;
                comboBox2.Visible = true;

                button1.Visible = true;

                label1.Visible = true;
            }

            else { list3Start(); }




            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (list1)
            {
                list1 = false;

                button1.Visible = false;
                label2.Visible = false;

                list2Start();

            }
            else if (list2)
            {
                Download();
            }
            
            if (Confirm)
            {
                list4Start();
            }








            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Enabled = false; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;

                MessageBox.Show("Ты же сам просил не затирать MBR");

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            list3 = false;

            Confirm = true;





        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (progressBar2.Value < 100)
            {
                progressBar2.Value += 1;
                label3.Text = progressBar2.Value.ToString() + "%";
            }

            else { this.Close(); timer2 = null; }


            

        }
    }
}
