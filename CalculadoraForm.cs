namespace Calculadora
{
    public partial class CalculadoraForm : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private string operacao = "";
        private bool novaEntrada = true;

        public CalculadoraForm()
        {
            InitializeComponent();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (novaEntrada)
            {
                textBox1.Text = "";
                novaEntrada = false;
            }

            textBox1.Text += btn.Text;
        }

        private void btnOperacao_Click(object sender, EventArgs e){
            Button btn = (Button)sender;
            valor1 = double.Parse(textBox1.Text);
            operacao = btn.Text;
            novaEntrada = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox1.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                    {
                        MessageBox.Show("Erro: Divisão por zero");
                        return;
                    }
                    break;
                case "x^y":
                    resultado = Math.Pow(valor1, valor2);
                    break;
                default:
                    MessageBox.Show("Operação inválida");
                    return;
            }

            textBox1.Text = resultado.ToString();
            novaEntrada = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            novaEntrada = true;
        }

        private void bntRaiz_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(textBox1.Text);
            if (valor >= 0){
                textBox1.Text = Math.Sqrt(valor).ToString();
            }
            else{
                MessageBox.Show("Erro: Raiz quadrada de número negativo");
            }
            novaEntrada = true;
        }
    }
}
