using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8_ComunicacionEntreForms_
{
    public partial class Form2 : Form
    {
        public string comentario; 
        public Form2(string pMensaje)  // se pasa por constructor el mensaje
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;
        }
        public string Comentario
        {
            set
            {
                comentario = value;
                lblComentario.Text = comentario;
            }
        }
    }
}
