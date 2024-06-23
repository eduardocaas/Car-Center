using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(80, ErrorMessage = "MaxLength")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Admissão")]
        public DateTime DataAdmissao { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(80, ErrorMessage = "MaxLength")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "Required")]
        public float Salario { get; set; }

        public float CalculoComissao(float ValorVenda)
        {
            // Comissão = 1% do valor da venda multiplicado por X anos (admissão) 
            return ValorVenda * 0.01F * (DateTime.Now.Year - DataAdmissao.Year);
        }
    }
}
