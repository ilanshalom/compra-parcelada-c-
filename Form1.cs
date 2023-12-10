namespace CompraParcelada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //click no bot�o Calcular:
            float valorFinalCompra = 0, valorParcelas = 0;
            try  //este comando permite tratamento de erros na entrada de dados
            {
                //pegar os valores digitados pelo usu�rio:
                float valorCompra = Convert.ToSingle(txtValorCompra.Text);
                int qtdeParcelas = Convert.ToInt16(txtQtdeParcelas.Text);
                //a seguir, colocamos a l�gica dos c�lculos:
                if (qtdeParcelas < 0)
                {
                    MessageBox.Show("A qtde. de parcelas deve ser positiva!", "Erro");
                }
                else if (qtdeParcelas == 0 || qtdeParcelas == 1)
                { //pagamento � vista:
                    valorFinalCompra = valorCompra;
                    valorParcelas = valorCompra;
                }
                else if (qtdeParcelas <= 3)
                {// duas ou tr�s parcelas => ter� 5% de juros:
                    valorFinalCompra = valorCompra + 5.0f / 100.0f * valorCompra;
                    valorParcelas = valorFinalCompra / qtdeParcelas;
                }
                else   //ou   else if (qtdeParcelas > 3)
                {// mais de tr�s parcelas => ter� 10% de juros:
                    valorFinalCompra = valorCompra + 10.0f / 100.0f * valorCompra;
                    valorParcelas = valorFinalCompra / qtdeParcelas;
                }
                lblTotalCompra.Text = "Valor final da compra: R$" + valorFinalCompra;
                lblValorParcelas.Text = "Valor das parcelas: R$ " + valorParcelas;
            }
            catch (Exception)
            { //caso os dados provoquem erro:
                MessageBox.Show("Digite dados corretos", "Erro");
            }
        }

    }
}