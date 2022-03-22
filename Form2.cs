using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Form2 form2 = new Form2();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String user = textBox1.Text;
            String password = textBox2.Text;
            Form3 form3 = new Form3();
            if(user == "" || password == "")
            {
                MessageBox.Show("vacio");
            }
            else if(user =="pt" & password == "foo") {
                MessageBox.Show("correcto");
                form3.Show();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }
    }
}
