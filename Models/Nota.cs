using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public int Numero { get; set; }
        [ValidateNever]
        [Display(Name = "Emissão")]
        [DataType(DataType.Date)]
        public DateTime? DataEmissao { get; set; }
        [ValidateNever]
        [DataType(DataType.Date)]
        public DateTime? Garantia { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Valor da venda")]
        public float ValorVenda { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "CPF do comprador")]
        public int CompradorId { get; set; }
        [ValidateNever]
        public Cliente Comprador { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Matrícula do vendedor")]
        public int VendedorId { get; set; }
        [ValidateNever]
        public Vendedor Vendedor { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Chassi do carro")]
        public int CarroId { get; set; }
        [ValidateNever]
        public Carro Carro { get; set; }
    }
}
