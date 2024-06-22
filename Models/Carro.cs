﻿using System.ComponentModel.DataAnnotations;

namespace CarCenter.Models
{
    public class Carro
    {
        public int Id { get; set; }
        [MaxLength(80, ErrorMessage = "Marca muito longa")]
        [Required(ErrorMessage = "Required")]
        public string Marca { get; set; }
        [MaxLength(80, ErrorMessage = "Modelo muito longo")]
        [Required(ErrorMessage = "Required")]
        public string Modelo { get; set; }
        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "Required")]
        public int AnoModelo { get; set; }
        [Display(Name = "Ano de Fabricação")]
        [Required(ErrorMessage = "Required")]
        public int AnoFabricacao { get; set; }
        [MaxLength(80, ErrorMessage = "Chassi muito longo")]
        [Required(ErrorMessage = "Required")]
        public string Chassi { get; set; }
        [DisplayFormat(DataFormatString = "{0:#,##0.00}")]
        [Required(ErrorMessage = "Required")]
        public float Preco { get; set; }
    }
}
