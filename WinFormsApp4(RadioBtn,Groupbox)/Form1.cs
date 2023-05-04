namespace WinFormsApp4_RadioBtn_Groupbox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Utilizamos un groupbox para que los grupos de radiobutton no se choquen con otro grupos de radiobutton
        // La diferencia con checkbox es que en este se selecciona solo una opcion
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            this.Text = "Calculadora";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r = 0.0;
            double a = 0.0;
            double b = 0.0;

            a = Convert.ToDouble(textA.Text);  //Convertir texto en double
            b = Convert.ToDouble(textB.Text);  //Convertir texto en double

            if (rbSuma.Checked == true) { r = a + b; }
            if (rbResta.Checked == true) { r = a - b; }
            if (rbMulti.Checked == true) { r = a * b; }
            if (rbDivision.Checked == true) { r = a / b; }
            label1.Text = r.ToString();   //Convertir double en texto ya que el label no soporta numeros 

        }
    }
}