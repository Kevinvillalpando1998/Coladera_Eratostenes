using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coladera_Erastotenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coladera eratostenes1 = new Coladera();

            txtmostrar.Clear();

            eratostenes1.comenzar();

            txtmostrar.Text = eratostenes1.ToString();
        }
    }
}
