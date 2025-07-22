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
        [Display(Name = "Quantidade")]
        [Range(1, 100, ErrorMessage = "A quantidade deve ser um número inteiro entre 1 e 100.")]
        public int quantity { get; set; } = 0;

        [Display(Name = "Valor unitário")]
        [Range(0.01, 100, ErrorMessage = "O valor unitário deve ser maior que zero e até no máximo 100.")]
        public double? unitPrice { get; set; } = null;
    }
}
