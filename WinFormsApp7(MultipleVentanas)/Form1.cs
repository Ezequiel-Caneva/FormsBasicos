namespace WinFormsApp7_MultipleVentanas_
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

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 miforma = new Form2(); // de esta forma abrimos 2 ventanas
            // miforma.Show();   forma no modal
            miforma.ShowDialog();  // muestra en forma modal : hace que no puedas interactuar en la primer ventana hasta que no cierras la segunda
        }
    }
}