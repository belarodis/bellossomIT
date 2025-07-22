using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace bellossomIT.Models
{
    public class FlowerModel
    {
        [Required(ErrorMessage = "A espécie precisa ser inserida.")]
        [StringLength(50, ErrorMessage = "A espécie não pode ter mais que 50 caracteres.")]
        [Display(Name = "Espécie")]
        public string specie { get; set; }

        [Display(Name = "Data de chegada")]
        [DataType(DataType.Date)]
        public DateTime arrivalDate { get; set; } = DateTime.UtcNow;

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
