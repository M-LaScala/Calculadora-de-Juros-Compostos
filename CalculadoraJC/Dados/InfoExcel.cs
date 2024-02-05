namespace CalculadoraJurosCompostos.Dados
{
    public class InfoExcel
    {

        public InfoExcel(int ano, float totalInvestido, float totalInvestidoPorAno, float valorMensal)
        {
            Ano = ano;
            TotalInvestido = totalInvestido;
            TotalInvestidoPorAno = totalInvestidoPorAno;
            ValorIncialProjetado = 0f;
            ValorFinalProjetado = 0f;
            RentabilidadeAnual = 0f;
            RentabilidadeTotal = 0f;
            ValorDoAporte = valorMensal;
        }

        public int Ano { get; set; }
        public float TotalInvestido { get; set; }
        public float TotalInvestidoPorAno { get; set; }
        public float ValorIncialProjetado { get; set; }
        public float ValorFinalProjetado { get; set; }
        public float RentabilidadeAnual { get; set; }
        public float RentabilidadeTotal { get; set; }
        public float ValorDoAporte { get; set; }
    }
}
