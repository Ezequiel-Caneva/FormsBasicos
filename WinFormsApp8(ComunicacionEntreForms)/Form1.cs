namespace WinFormsApp8_ComunicacionEntreForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnvio1_Click(object sender, EventArgs e)
        {

            //Creamos la instancia de la forma 2 y mandamos el mensaje por constructor
            Form2 miforma2 = new Form2(textboxMensaje.Text);
            //mandamos medianto propiedades
            miforma2.Comentario = "Nos vemos";
            //mostramos el form
            miforma2.ShowDialog();
        }

        private void btnEnvio2_Click(object sender, EventArgs e)
        {

        }
    }
}