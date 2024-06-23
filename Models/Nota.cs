using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Emissão")]
        public DateTime DataEmissao { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Garantia { get; set; }
        public float ValorVenda { get; set; }

        public int CompradorId { get; set; }
        public Cliente Comprador { get; set; }

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        public int CarroId { get; set; }
        public Carro Carro { get; set; }
    }
}
