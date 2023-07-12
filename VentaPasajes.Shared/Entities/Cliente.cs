using System.ComponentModel.DataAnnotations;

namespace VentaPasajes.Shared.Entities
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(60, ErrorMessage = "El campo {0} no puede tener mas de {1} caractéres")]
        public string Nombre_Cliente { get; set; } = null!;
        public string? Celular { get; set; } = null;
        public virtual ICollection<Detalle_Pasaje> Detalle_Pasajes { get; set; } = null!;
        public virtual ICollection<Encomienda> Encomiendas { get; set; } = null!;

    }
}
