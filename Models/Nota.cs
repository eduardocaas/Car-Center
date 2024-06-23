using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [Display(Name = "Emissão")]
        public DateTime DataEmissao { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        public DateTime Garantia { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Valor da venda")]
        public float ValorVenda { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Nome do comprador")]
        public int CompradorId { get; set; }
        public Cliente Comprador { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Nome do vendedor")]
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Chassi do carro")]
        public int CarroId { get; set; }
        public Carro Carro { get; set; }
    }
}
