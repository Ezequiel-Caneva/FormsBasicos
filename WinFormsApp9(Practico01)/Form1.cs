namespace WinFormsApp9_Practico01_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            double costo = 0;
            string cotizacion = "";

            cotizacion = "Cotizacion de auto para: " + textBoxNombre.Text +"\r\n";

            //obtener costo inicial
            costo = Convert.ToDouble(textboxCosto.Text);

            //verificar seguro

            if (rbnBasico.Checked == true)
            {
                costo = costo + 500;
                cotizacion += "Lleva seguro basico de $500  \r\n";
            }
            if (rbnTerceros.Checked == true)
            {

                costo = costo + 700;
                cotizacion += "Lleva seguro contra terceros de $700 \r\n";
            }
            if (rbnTotal.Checked == true)
            {
                costo = costo + 1000;
                cotizacion += "Lleva seguro total de $1000 \r\n";
            }
            // Verificar equipo
            if (cbxAire.Checked == true)
            {
                costo = costo + 500;
                cotizacion += "Con aire acondicionado $500 \r\n";
            }
            if (cbxAudio.Checked == true)
            {
                costo = costo + 500;
                cotizacion += "Con sistema de audio $700 \r\n";
            }
            //Mostramos total 

            cotizacion += "El total a pagar es de " + costo.ToString();

            textBoxCotizacion.Text = cotizacion;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}