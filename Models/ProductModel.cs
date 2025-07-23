using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using bellossomIT.Models.Enuns;

namespace bellossomIT.Models
{
    public abstract class ProductModel
    {
        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Display(Name = "Quantidade")]
        [Range(1, 10000, ErrorMessage = "A quantidade deve ser um número inteiro maior que 1.")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "O valor unitário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor unitário deve ser maior que zero.")]
        [Display(Name = "Valor unitário")]
        public double unitPrice { get; set; }
    }

}
