namespace CarCenter.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }
        public float Salario { get; set; }

        public float CalculoComissao(float ValorVenda)
        {
            // Comissão = 1% do valor da venda multiplicado por X anos (admissão) 
            return ValorVenda * 0.01F * (DateTime.Now.Year - DataAdmissao.Year);
        }
    }
}
