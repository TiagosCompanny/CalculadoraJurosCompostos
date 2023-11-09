using System.Globalization;
using Abtrix.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abtrix
{
    public partial class Calculadora_Juros_Compostos : Form
    {
        public Calculadora_Juros_Compostos()
        {
            InitializeComponent();
        }

        public double valorInicial { get; set; }
        public double valorAporteMensal { get; set; }
        public double valorFinal { get; set; }
        public double valorInvestido { get; set; }
        public int periodo_Meses { get; set; }
        public double taxa_Mensal { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem = "Personalizado";
            textBox2.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Calcular(object sender, EventArgs e)
        {
            //Verificação se todos os valores estão rpeenchidos
            if (!VerificacaoPreenchimentoDeCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos necessários.");
            }
            else
            {
                //Variaveis
                valorInicial = double.Parse(textBox1.Text);
                valorAporteMensal = double.Parse(textBox4.Text);
                taxa_Mensal = double.Parse(textBox2.Text);

                PreencherCamposCalculados(valorInicial, valorAporteMensal, taxa_Mensal);
            }



        }
        private bool VerificacaoPreenchimentoDeCampos()
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text))
            {         
                return false;
            }
            return true;
        }

        private void PreencherCamposCalculados(double valorInicial, double valorAporteMensal, double taxa_Mensal)
        {

            if (radioButton2.Checked)
            {
                taxa_Mensal = Math.Pow(1 + (taxa_Mensal / 100), 1.0 / 12) - 1;

            }
            else
            {
                taxa_Mensal /= 100;
            }

            periodo_Meses = int.Parse(textBox5.Text);
            if (radioButton5.Checked)
            {
                periodo_Meses *= 12;
            }

            Calculo calculo = new Calculo();

            valorFinal = calculo.CalcularJurosCompostos(valorInicial, valorAporteMensal, taxa_Mensal, periodo_Meses);
            valorInvestido = calculo.CalcularTotalAportado(valorAporteMensal, periodo_Meses) + valorInicial;
            richTextBox1.Text = valorFinal.ToString("C", new CultureInfo("pt-BR"));
            richTextBox2.Text = valorInvestido.ToString("C", new CultureInfo("pt-BR"));
            richTextBox3.Text = (valorFinal - valorInvestido).ToString("C", new CultureInfo("pt-BR"));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juros compostos são uma forma de cálculo de juros em que o valor dos juros é calculado não \n" +
                "apenas sobre o valor principal inicial, mas também sobre os juros acumulados anteriormente. \n" +
                "Em resumo, juros compostos significam que você ganha juros sobre os juros, o que leva a um crescimento mais rápido do seu investimento ao longo do tempo.\n" +
                " Em contraste, os juros simples são calculados apenas sobre o valor principal, sem considerar os juros acumulados anteriormente.\n" +
                " Os juros compostos são amplamente usados em investimentos e empréstimos, e geralmente resultam em ganhos financeiros mais substanciais a longo prazo.");
        }

     

        private void button_ImpotarPlanilha(object sender, EventArgs e)
        {
            //Verificação se todos os valores estão rpeenchidos
            if (!VerificacaoPreenchimentoDeCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos necessários.");
            }
            else
            {
                Planilha planilha = new Planilha();
                planilha.GerarTabelaJurosCompostos((decimal)valorInicial, periodo_Meses, (decimal)valorAporteMensal, (decimal)taxa_Mensal);
                planilha.GerarGraficoJurosCompostos(periodo_Meses);
                MessageBox.Show("O arquivo PlanilhaJurosCompostos.xlsx foi gerada e enviada para sua área de trabalho");

            }
        }


    }
}