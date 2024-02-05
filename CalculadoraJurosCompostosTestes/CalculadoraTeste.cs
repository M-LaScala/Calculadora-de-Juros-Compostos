using CalculadoraJurosCompostos;

namespace CalculadoraJurosCompostosTestes
{
    [TestClass]
    public class CalculadoraTeste
    {
        #region Testes simples

        // Calcular rendimento sem depósitos mensais sem aumento anual
        [TestMethod]
        public void CalcularSomenteJurosCompostosValorInicial()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "500";                 // valorInicial
            calculadora.textBox2.Text = "0";                   // valorMensal
            calculadora.textBox3.Text = "12";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "0";                   // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 552,14");   // valorFinal
        }

        // Calcular rendimento com somente depósitos mensais sem aumento anual
        [TestMethod]
        public void CalcularSomenteJurosCompostosValorMensal()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "0";                   // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "12";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "0";                   // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 6.281,58"); // valorFinal
        }

        // Calcular rendimento com somente depósitos mensais, mais aumento anual
        [TestMethod]
        public void CalcularJurosCompostosValorMensalComAumentoAnual()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "0";                   // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "24";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "250";                 // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 16.358,96");   // valorFinal
        }

        // Calcular rendimento com depósito inicial, mais depósitos mensais sem aumento anual
        [TestMethod]
        public void CalcularJurosCompostosValorMensalComValorInicial()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "500";                 // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "12";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "0";                   // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 6.833,72");   // valorFinal
        }

        // Calcular rendimento com depósito inicial, mais depósitos mensais com aumento anual
        [TestMethod]
        public void CalcularJurosCompostosValorMensalComValorInicialComAumentoAnual()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "6000";                // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "24";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "250";                 // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 23.675,48");   // valorFinal
        }

        #endregion

        #region Testes complexos

        // Calcular rendimento com somente depósitos mensais, mais aumento anual
        [TestMethod]
        public void GrandeCalcularJurosCompostosValorMensalComAumentoAnual()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "0";                   // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "48";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "250";                 // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 49.525,58");   // valorFinal
        }

        // Calcular rendimento com depósito inicial, mais depósitos mensais com aumento anual
        [TestMethod]
        public void GrandeCalcularJurosCompostosValorMensalComValorInicialComAumentoAnual()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "6000";                // valorInicial
            calculadora.textBox2.Text = "500";                 // valorMensal
            calculadora.textBox3.Text = "48";                  // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "250";                 // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 58.447,52");   // valorFinal
        }

        // Calcular rendimento com depósito inicial, mais depósitos mensais com aumento anual
        [TestMethod]
        public void TesteProjecaoFinal()
        {
            object obj = new object();
            EventArgs e = new EventArgs();
            Calculadora calculadora = new Calculadora();
            calculadora.textBox1.Text = "8.772";               // valorInicial
            calculadora.textBox2.Text = "750";                 // valorMensal
            calculadora.textBox3.Text = "192";                 // tempoInvestido em meses
            calculadora.textBox4.Text = "0,83";                // taxaDeJuros AM
            calculadora.textBox8.Text = "250";                 // valorAumentoAnual

            calculadora.button1_Click(obj, e);

            Assert.IsTrue(calculadora.textBox5.Text == "R$ 1.035.791,94");   // valorFinal
        }

        #endregion
    }
}