using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace bellossomIT.Models
{
    public class FlowerModel : ProductModel
    {
        [Required(ErrorMessage = "A espécie precisa ser inserida.")]
        [StringLength(50, ErrorMessage = "A espécie não pode ter mais que 50 caracteres.")]
        [Display(Name = "Espécie")]
        public string species { get; set; }

        [Display(Name = "Data de chegada")]
        [DataType(DataType.Date)]
        public DateTime arrivalDate { get; set; } = DateTime.UtcNow;

    }
}
