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


             DialogResult r = MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore , MessageBoxIcon.Error);

            if (r == DialogResult.Abort)
            {
                int z = 1;
                do
                {
                    DialogResult g = MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    lblMensaje.Text = "Omitir";
                } while (z == 1);
            }
            if (r == DialogResult.Retry)
            {
                DialogResult f = MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                lblMensaje.Text = "Reintentar";
            }
            if (r == DialogResult.Ignore)
            {
                DialogResult j = MessageBox.Show("Probamos botones", "Diferentes Botones", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                lblMensaje.Text = "Ignorar";
            }
        }
    }
}