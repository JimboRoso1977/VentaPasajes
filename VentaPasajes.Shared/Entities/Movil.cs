using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Movil
    {
        [Key]
        public int Id_Movil { get; set; }

        [Display(Name = "Nombre Conductor")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_Chofer { get; set; } = null!;

        [Display(Name = "Codigo Interno")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Codigo_Movil { get; set; } = null!;

        [Display(Name = "Estado de Movil")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Estado { get; set; } = null!;

        [Display(Name = "Nro. de Celular")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Celular_Chofer { get; set; } = null!;
        public virtual ICollection<Pasaje> Pasajes { get; set; } = null!;
        public virtual ICollection<Encomienda> Encomiendas { get; set; } = null!;
    }
}
