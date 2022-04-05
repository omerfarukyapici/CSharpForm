using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpForm
{
    public partial class Form1 : Form
    {

        string defaultTextContent = "Default Value";

        public Form1()
        {
            InitializeComponent();
        }

        /*This is the Form1 Double Click event*/
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label3.Text = "When you click double I did change.";
            
        }


        /*This is the Form1 Mouse Hover Click event*/
        private void Form1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
        }


        private void label3_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            string textBox1Value = textBox1.Text;
            label3.Text = textBox1Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = defaultTextContent;
        }


        /*Login Page*/

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox2.Text;
            string userPassword = textBox3.Text;



            if (userName == "Ömer Faruk")
            {

                if (userPassword == "12345")
                {
                    label7.Text = "Welcome" + " " + userName;
                }else
                {
                    label7.Text = "Password is wrong !";
                }

            }else
            {
                label7.Text = "User Name is wrong !";
            }

        }


    }
}
