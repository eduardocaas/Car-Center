﻿using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [MaxLength(80, ErrorMessage = "Marca muito longa")]
        public string Marca { get; set; }
        [MaxLength(80, ErrorMessage = "Modelo muito longo")]
        public string Modelo { get; set; }
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }
        [MaxLength(80, ErrorMessage = "Chassi muito longo")]
        public string Chassi { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        public float Preco { get; set; }
    }
}
