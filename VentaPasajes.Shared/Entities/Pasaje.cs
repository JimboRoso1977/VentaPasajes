using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Pasaje
    {
        [Key]
        public int Id_Pasaje { get; set; }

        [Display(Name = "Monto Total")]
        public float Monto_Total { get; set; }

        [Display(Name = "Origen")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Origen { get; set; } = null!;

        [Display(Name = "Destino")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Destino { get; set; } = null!;
        public int Cantidad_Pasajes { get; set; }

        [Display(Name = "Nro. Movil")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Movil { get; set; } = null!;

        [Display(Name = "Fecha de Registro")]
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;

        [ForeignKey("Usu")]
        public int Id_Usuario { get; set; }
        public virtual Usuario Usu { get; set; } = null!;

        [ForeignKey("Mov")]
        public int Id_Movil { get; set; }
        public virtual Movil Mov { get; set; } = null!;
        public virtual ICollection<Detalle_Pasaje> Detalle_Pasajes { get; set; } = null!;
    }
}
