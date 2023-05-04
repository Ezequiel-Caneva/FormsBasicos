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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            this.Text = "Programa 01";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Hola a todos";
        }

        private void btDespedida_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "Adios";
            this.Text = "Bye!";  // referenciar al texto del programa
        }
    }
}
