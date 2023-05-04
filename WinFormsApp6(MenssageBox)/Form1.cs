namespace WinFormsApp6_MenssageBox_
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hola a todos")

            // MessageBox.Show("hola a todos" , "Mi Messagebox"); // con el segundo string le das titulo a la ventana

            // MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore); // agregamos botones


             DialogResult r = MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore , MessageBoxIcon.Stop);

            if (r == DialogResult.Abort)
            {
                lblMensaje.Text = "Omitir";
            }
            if (r == DialogResult.Retry)
            {
                lblMensaje.Text = "Reintentar";
            }
            if (r == DialogResult.Ignore)
            {
                lblMensaje.Text = "Ignorar";
            }
        }
    }
}