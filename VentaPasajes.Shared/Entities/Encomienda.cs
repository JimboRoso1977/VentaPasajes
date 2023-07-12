using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Encomienda
    {
        [Key]
        public int Id_Encomienda { get; set; }

        [Display(Name = "Nombre del que Envía")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_Cliente_Origen { get; set; } = null!;

        [Display(Name = "Nombre del que Recibe")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_Cliente_Destino { get; set; } = null!;

        [Display(Name = "Aclaracion")]
        public string? Aclaracion { get; set; }

        [Display(Name = "Origen de Encomienda")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Origen { get; set; } = null!;

        [Display(Name = "Destino de Encomienda")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Destino { get; set; } = null!;
        public float Monto_Total { get; set; }
        public string Movil { get; set; } = null!;
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;

        [ForeignKey("Usu")]
        public int Id_Usuario { get; set; }
        public virtual Usuario Usu { get; set; } = null!;

        [ForeignKey("Mov")]
        public int MovilId { get; set; }
        public virtual Movil Mov { get; set; } = null!;
        [ForeignKey("Clie")]
        public int ID_Cliente { get; set; }
        public virtual Cliente Clie { get; } = null!;
        public virtual ICollection<Detalle_Encomienda> Detalle_Encomiendas { get; set; } = null!;
    }
}
