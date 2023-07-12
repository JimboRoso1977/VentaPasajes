using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Datos_Sorteo
    {
        [Key]
        public int Id_Sorteo { get; set; }

        [Display(Name = "Nombre Sorteo")]
        [Required(ErrorMessage = "El campo {0} es oblihgatorio.")]
        public string Nombre_Sorteo { get; set; } = null!;

        [Display(Name = "Fecha Inicio de emición de tikets")]
        public DateTime Fecha_Inicio { get; set; }

        [Display(Name = "Fecha Final de emición de tikets")]
        public DateTime Fecha_Fin { get; set; }

        [Display(Name = "Fecha del Sorteo")]
        public DateTime Fecha_Sorteo { get; set; }

        public string Codigo_Usuario { get; set; } = null!;

        public virtual ICollection<Datos_Tiket> Datos_Tikets { get; set; } = null!;
        public virtual ICollection<Encomienda> Encomiendas { get; set; } = null!;

    }
}
