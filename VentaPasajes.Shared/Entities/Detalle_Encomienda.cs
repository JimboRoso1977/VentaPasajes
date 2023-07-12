using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VentaPasajes.Shared.Entities
{
    public class Detalle_Encomienda
    {
        [Key]
        public int ID_Detalle_Encomienda { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Cantidad { get; set; }

        [Display(Name = "Detalle")]
        [MaxLength(60, ErrorMessage = "El campo {0} de tener máximo {1} carácteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Detalle { get; set; } = null!;

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float Monto { get; set; }

        [ForeignKey("Enco")]
        public int ID_Encomienda { get; set; }
        public virtual Encomienda Enco { get; set; } = null!;
    }
}
