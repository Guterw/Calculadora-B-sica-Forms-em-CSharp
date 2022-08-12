namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int operacao = 1;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 2;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 1;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 4;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            double resultado;

            numero1 = Double .Parse(textBox1.Text);
            numero2 = Double.Parse(textBox2.Text);

            if (operacao == 1)
            {
                resultado = numero1 + numero2;
                textBox3.Text = resultado.ToString();
            }
            if (operacao == 2)
            {
                resultado = numero1 - numero2;
                textBox3.Text = resultado.ToString();
            }
            if (operacao == 3 && numero2 !=0)
            {
                resultado = numero1 / numero2;
                textBox3.Text = resultado.ToString();
            }
            if (operacao == 4)
            {
                resultado = numero1 * numero2;
                textBox3.Text = resultado.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operacao = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
            
        }
    }
}