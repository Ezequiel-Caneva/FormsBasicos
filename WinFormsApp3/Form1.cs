namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Resultado.Text = "";
            this.Text = "Calculadora";
            txtA.Text = "0";
            txtB.Text = "0";


        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a + b;
            Resultado.Text = r.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a - b;
            Resultado.Text = r.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double r = a * b;
            Resultado.Text = r.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            if (b != 0)
            {
                double r = a / b;
                Resultado.Text = r.ToString();

            }
            else
            {
                Resultado.Text = "No se puede dividir entre 0";
            }
           
        }
    }
}