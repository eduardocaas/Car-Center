using CarCenter.Validations;
using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        [CpfValidation(errorMessage: "Insira um CPF válido")]
        public string CPF { get; set; }
    }
}
