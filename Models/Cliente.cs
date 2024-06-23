using CarCenter.Validations;
using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [EmailAddress]
        [Required]
        [MaxLength(80)]
        public string Email { get; set; }
        [Required]
        [MaxLength(11)]
        public string Telefone { get; set; }
        [Required]
        [MaxLength(200)]
        public string Endereco { get; set; }
        [CpfValidation(errorMessage: "Insira um CPF válido")]
        [Required]
        [MaxLength(11)]
        public string CPF { get; set; }
    }
}
