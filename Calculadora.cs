using CalculadoraJurosCompostos.Dados;
using OfficeOpenXml;
using System.Globalization;

namespace CalculadoraJurosCompostos
{
    public partial class Calculadora : Form
    {
        public List<InfoExcel> dados = new List<InfoExcel>();

        public Calculadora()
        {
            InitializeComponent();  
        }

        public void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;

            float valorInicial = 0, valorMensal = 0, taxaDeJuros = 0, tempoInvestido = 0, valorAumentoAnual = 0;
            int tempoInvestidoAnos;

            try
            {
                valorInicial = float.Parse(textBox1.Text);
                valorMensal = float.Parse(textBox2.Text);
                tempoInvestido = float.Parse(textBox3.Text);
                taxaDeJuros = float.Parse(textBox4.Text);
                valorAumentoAnual = float.Parse(textBox8.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            float jurosSem = taxaDeJuros / 100;
            float valorFinal = 0;
            float rendimentos = 0;
            // float valorInvestido = valorInicial + (valorMensal * tempoInvestido);
            float valorInvestido = 0;

            float auxValorMensal = valorMensal;
            // Acrescentado a logica para aumento de valor anual no aporte!
            if (tempoInvestido % 12 == 0 && valorAumentoAnual != 0)
            {
                tempoInvestidoAnos = (int)(tempoInvestido / 12);

                for (int i = 0; i < tempoInvestidoAnos; i++)
                {
                    valorInvestido += auxValorMensal * 12;
                    InfoExcel dado = new InfoExcel
                        (
                            DateTime.Now.Year + i,
                            valorInvestido,
                            auxValorMensal * 12,
                            auxValorMensal
                        );
                    dados.Add(dado);

                    auxValorMensal += valorAumentoAnual;
                }
            }
            else
            {
                valorInvestido = valorInicial + (auxValorMensal * tempoInvestido);
                tempoInvestidoAnos = 0;
            }

            #region Parte logica com as formulas
            if (valorInicial > 0 && valorMensal <= 0 && valorAumentoAnual <= 0)
            {
                // Calcular rendimento sem depósitos mensais sem aumento anual
                // Montante = CapitalInicial x ( (1 + jurosSem) ^ tempo )
                valorFinal = (float)(valorInicial * (Math.Pow((1 + jurosSem), tempoInvestido)));
                rendimentos = valorFinal - valorInicial;
            }
            else if (valorInicial <= 0 && valorMensal > 0 && valorAumentoAnual <= 0)
            {
                // Calcular rendimento com somente depósitos mensais sem aumento anual
                // Montante = Aportes × ( ( (1 + jurosSem) ^ tempo − 1) ÷ jurosSem );
                valorFinal = (float)(valorMensal * (Math.Pow((1 + jurosSem), tempoInvestido) - 1) / jurosSem);
                rendimentos = valorFinal - (valorMensal * tempoInvestido);
            }
            else if (valorInicial <= 0 && valorMensal > 0 && valorAumentoAnual > 0 && tempoInvestidoAnos >= 1)
            {
                // Calcular rendimento com somente depósitos mensais, mais aumento anual
                valorFinal = (float)(valorMensal * (Math.Pow((1 + jurosSem), 12) - 1) / jurosSem);

                #region Preenchendo ano inicial
                dados[0].ValorIncialProjetado = 0f;
                dados[0].ValorFinalProjetado = valorFinal;
                dados[0].RentabilidadeAnual = valorFinal - (valorMensal * 12);
                dados[0].RentabilidadeTotal = dados[0].RentabilidadeAnual;
                #endregion

                valorInicial = valorFinal;

                for (int i = 1; i <= tempoInvestidoAnos - 1; i++)
                {
                    dados[i].ValorIncialProjetado = valorInicial;

                    valorMensal += valorAumentoAnual;
                    valorFinal = (float)((valorInicial * Math.Pow(1 + jurosSem, 12)) + (valorMensal * (Math.Pow(1 + jurosSem, 12) - 1) / jurosSem));

                    dados[i].ValorFinalProjetado = valorFinal;
                    dados[i].RentabilidadeAnual = valorFinal - (valorInicial + (valorMensal * 12));

                    valorInicial = valorFinal;

                    dados[i].RentabilidadeTotal = dados[i].RentabilidadeAnual + dados[i - 1].RentabilidadeTotal;
                }
                rendimentos = valorFinal - valorInvestido;
            }
            else if (valorInicial > 0 && valorMensal > 0 && valorAumentoAnual <= 0)
            {
                // Calcular rendimento com depósito inicial, mais depósitos mensais sem aumento anual
                // Montante = (CapitalInicial x ((1 + jurosSem) ^ tempo)) + (valorMensal × (((((1 + jurosSem)) ^ tempo ) − 1) ÷ jurosSem)).
                valorFinal = (float)((valorInicial * Math.Pow(1 + jurosSem, tempoInvestido)) + (valorMensal * (Math.Pow(1 + jurosSem, tempoInvestido) - 1) / jurosSem));
                rendimentos = valorFinal - ((valorMensal * tempoInvestido) + valorInicial);
            }
            else if (valorInicial > 0 && valorMensal > 0 && valorAumentoAnual > 0 && tempoInvestidoAnos >= 1)
            {
                // Calcular rendimento com depósito inicial, mais depósitos mensais com aumento anual
                float valorInicialParam = valorInicial;
                valorFinal = (float)((valorInicial * Math.Pow(1 + jurosSem, 12)) + (valorMensal * (Math.Pow(1 + jurosSem, 12) - 1) / jurosSem));

                #region Preenchendo ano inicial
                dados[0].ValorIncialProjetado = valorInicialParam;
                dados[0].ValorFinalProjetado = valorFinal;
                dados[0].TotalInvestidoPorAno = dados[0].TotalInvestidoPorAno + valorInicialParam;
                dados[0].RentabilidadeAnual = valorFinal - ((valorMensal * 12) + valorInicialParam);
                dados[0].RentabilidadeTotal = dados[0].RentabilidadeAnual;
                #endregion

                valorInicial = valorFinal;
                for (int i = 1; i <= tempoInvestidoAnos - 1; i++)
                {
                    dados[i].ValorIncialProjetado = valorInicial;
                    dados[i].TotalInvestido += valorInicialParam;
                    
                    valorMensal += valorAumentoAnual;
                    valorFinal = (float)((valorInicial * Math.Pow(1 + jurosSem, 12)) + (valorMensal * (Math.Pow(1 + jurosSem, 12) - 1) / jurosSem));

                    dados[i].ValorFinalProjetado = valorFinal;
                    dados[i].RentabilidadeAnual = valorFinal - (valorInicial + (valorMensal * 12));

                    valorInicial = valorFinal;

                    dados[i].RentabilidadeTotal = dados[i - 1].RentabilidadeTotal + dados[i].RentabilidadeAnual;
                }
                valorInvestido += valorInicialParam;
                rendimentos = valorFinal - valorInvestido;
            }
            else
            {
                // Não é póssivel calcular o rendimento
                Console.WriteLine("Erro ao calcular o rendimento!");
            }
            #endregion

            textBox5.Text = $"{valorFinal.ToString("C", CultureInfo.CurrentCulture)}";
            textBox6.Text = $"{rendimentos.ToString("C", CultureInfo.CurrentCulture)}";
            textBox7.Text = $"{valorInvestido.ToString("C", CultureInfo.CurrentCulture)}";

            // Se tiver valor aumentoAnual disponibilizar excel
            if (valorAumentoAnual > 0)
            {
                button2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage($"{AppDomain.CurrentDomain.BaseDirectory}Investimentos.xlsx"))
            {

                if(package.Workbook.Worksheets.Count > 0)
                {
                    package.Workbook.Worksheets.Delete("Investimento");
                }

                var sheet = package.Workbook.Worksheets.Add("Investimento");
                
                int i = 1;

                sheet.Cells[$"A{i}"].Value = "Ano";
                sheet.Cells[$"B{i}"].Value = "Total Investido";
                sheet.Cells[$"C{i}"].Value = "Total Investido Por Ano";
                sheet.Cells[$"D{i}"].Value = "Valor Incial Projetado";
                sheet.Cells[$"E{i}"].Value = "Valor Final Projetado";
                sheet.Cells[$"F{i}"].Value = "Rentabilidade Anual";
                sheet.Cells[$"G{i}"].Value = "Rentabilidade Total";
                sheet.Cells[$"H{i}"].Value = "Valor Do Aporte";

                foreach (var dado in dados)
                {
                    i++;

                    sheet.Cells[$"A{i}"].Value = dado.Ano;
                    sheet.Cells[$"B{i}"].Value = string.Format("{0:N2}", dado.TotalInvestido);
                    sheet.Cells[$"C{i}"].Value = string.Format("{0:N2}", dado.TotalInvestidoPorAno);
                    sheet.Cells[$"D{i}"].Value = string.Format("{0:N2}", dado.ValorIncialProjetado);
                    sheet.Cells[$"E{i}"].Value = string.Format("{0:N2}", dado.ValorFinalProjetado);
                    sheet.Cells[$"F{i}"].Value = string.Format("{0:N2}", dado.RentabilidadeAnual);
                    sheet.Cells[$"G{i}"].Value = string.Format("{0:N2}", dado.RentabilidadeTotal);
                    sheet.Cells[$"H{i}"].Value = dado.ValorDoAporte;
                }
                
                // Save to file
                package.Save();
            }
        }
    }
}
