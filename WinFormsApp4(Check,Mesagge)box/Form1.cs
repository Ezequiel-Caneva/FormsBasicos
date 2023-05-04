using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp4_Check_Mesagge_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (checkMonitor.Checked == true)
            {
                total = total + 250;
            }
            if (checkTeclado.Checked == true)
            {
                total = total + 150;
            }
            if (checkMouse.Checked == true)
            {
                total = total + 20;
            }

            MessageBox.Show($"El total es {total.ToString()}"); //crea una ventana para mostrar el resultado en lugar de poner un label 
        }

        private void checkMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMonitor.Checked == true)
            {
                lblResultado.Text = "Selecciono Monitor";
            }
            else
                lblResultado.Text = "";
        }

        private void checkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTeclado.Checked == true)
            {
                lblResultado.Text = "Selecciono Teclado";
            }
            else
                lblResultado.Text = "";
        }

        private void checkMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMouse.Checked == true)
            {
                lblResultado.Text = "Selecciono Mouse";
            }
            else
                lblResultado.Text = "";
        }
    }
}