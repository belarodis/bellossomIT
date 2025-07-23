using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using bellossomIT.Models.Enuns;


namespace bellossomIT.Models
{
    public class VaseModel : ProductModel
    {
        [Required(ErrorMessage = "O material precisa ser selecionado.")]
        [Display(Name = "Material")]
        public VaseMaterial material { get; set; }

        [Required(ErrorMessage = "O tamanho precisa ser selecionado.")]
        [Display(Name = "Tamanho")]
        public VaseSize size { get; set; }

    }
}
