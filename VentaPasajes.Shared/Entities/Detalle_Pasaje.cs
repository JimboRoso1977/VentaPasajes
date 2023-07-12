using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Detalle_Pasaje
    {
        [Key]
        public int Id_Detalle { get; set; }

        [Display(Name = "Origen")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Origen { get; set; } = null!;

        [Display(Name = "Destino")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Destino { get; set; } = null!;

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float Precio { get; set; }
        public DateTime Fecha_Hora { get; set; } = DateTime.Now;
        [ForeignKey("Pasj")]
        public int Id_Pasaje { get; set; }
        public virtual Pasaje Pasj { get; set; }
        [ForeignKey("Clie")]
        public int Id_Cliente { get; set; }
        public virtual Cliente Clie { get; set; }
    }
}
