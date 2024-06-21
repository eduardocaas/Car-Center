namespace CarCenter.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime DataEmissao { get; set; }
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
