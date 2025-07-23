using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using bellossomIT.Models.Enuns;

namespace bellossomIT.Models
{
    public abstract class ProductModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Display(Name = "Quantidade")]
        [Range(1, 10000, ErrorMessage = "A quantidade deve ser um número inteiro maior que 1.")]
        public int quantity { get; set; }
    }

}
