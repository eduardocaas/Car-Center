using CarCenter.Validations;
using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(80, ErrorMessage = "MaxLength")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Required")]
        [MaxLength(80, ErrorMessage = "MaxLength")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(11, ErrorMessage = "MaxLength")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Required")]
        [MaxLength(200, ErrorMessage = "MaxLength")]
        public string Endereco { get; set; }
        [CpfValidation(errorMessage: "Insira um CPF válido")]
        [Required(ErrorMessage = "Required")]
        [MaxLength(11, ErrorMessage = "MaxLength")]
        public string CPF { get; set; }
    }
}
