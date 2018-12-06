using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Gray;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            {
                x = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                x = 0;
            }
            if (x > 9999)
            {
                MessageBox.Show("Numarul este prea mare");
            }
            int k = 0;
            if (x > 2)
            {
                for (int i = 2; i < x / 2; i++)
                {
                    if (x % i == 0)
                    {
                        k = 1;
                    }

                }
                if (k == 1)
                {
                   BackColor = Color.Red;
                    label2.Text = "Numărul este prim.";
                }
                else
                {
                    BackColor = Color.Green;
                    label2.Text = "Numărul nu este prim.";
                }
            }
            else
            {
                label.Text = "Introduceti o valoare mai mare";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   

}
