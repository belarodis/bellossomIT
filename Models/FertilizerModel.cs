using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace bellossomIT.Models
{
    public class FertilizerModel
    {

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        [Display(Name = "Categoria")]
        [Range(1, int.MaxValue, ErrorMessage = "A categoria precisa ser selecionada.")]
        public FertilizerCategoryEnum category { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.")]
        [Display(Name = "Marca")]
        [StringLength(100, ErrorMessage = "A marca não pode exceder 100 caracteres.")]
        public string brand { get; set; } = string.Empty;

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Display(Name = "Quantidade")]
        [Range(1, 100, ErrorMessage = "A quantidade deve ser um número inteiro entre 1 e 100.")]
        public int quantity { get; set; } = 0;

        [Display(Name = "Valor unitário")]
        [Range(0.01, 100, ErrorMessage = "O valor unitário deve ser maior que zero e até no máximo 100.")]
        public double? unitPrice { get; set; } = null;
    }
}
