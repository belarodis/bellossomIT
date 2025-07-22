using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace bellossomIT.Models
{
    public class VaseModel
    {
        [Required(ErrorMessage = "O material precisa ser selecionado.")]
        [Display(Name = "Material")]
        public VaseMaterialEnum material { get; set; }

        [Required(ErrorMessage = "O tamanho precisa ser selecionado.")]
        [Display(Name = "Tamanho")]
        public VaseSizeEnum size { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(1, 10000, ErrorMessage = "A quantidade deve ser um número inteiro maior que 1.")]
        [Display(Name = "Quantidade")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "O valor unitário é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor unitário deve ser maior que zero.")]
        [Display(Name = "Valor unitário")]
        public double unitPrice { get; set; }
    }
}
