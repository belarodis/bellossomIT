using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using bellossomIT.Models.Enuns;

namespace bellossomIT.Models
{
    public class FertilizerModel: ProductModel
    {

        [Required(ErrorMessage = "A categoria precisa ser selecionada.")]
        [Display(Name = "Categoria")]
        public FertilizerCategory category { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória.")]
        [Display(Name = "Marca")]
        [StringLength(50, ErrorMessage = "A marca não pode exceder 50 caracteres.")]
        public string brand { get; set; }

        [Required(ErrorMessage = "O peso precisa ser selecionado.")]
        [Display(Name = "Peso")]
        public int weight { get; set; }

    }
}
