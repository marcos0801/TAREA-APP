using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_APP
{
    public partial class cuadrado_de_unnumero : Form
    {
        public cuadrado()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            private void button3_Click(object sender, EventArgs e)
            {
                int nu;
                if (this.n.Text.Length == 0)
                {
                    MessageBox.Show("OJO, cajas de textos vacia...!!");
                    this.n.Focus();
                    return;
                }

            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
             this.n.Text = "";
            this.r.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            x = nu
                  return x;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            x = nu * nu;
            return x;
        }
    }
