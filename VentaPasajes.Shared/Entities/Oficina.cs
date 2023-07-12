using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Oficina
    {
        [Key]
        public int Id_Oficina { get; set; }

        [Display(Name = "Nombre de Parada")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_Oficina { get; set; } = null!;

        [Display(Name = "Teléfono fijo")]
        public string Telefono { get; set; } = null!;

        [Display(Name = "Celular")]
        public string Celular { get; set; } = null!;
        public string Codigo_Oficina { get { return "OFIC-" + Id_Oficina.ToString(); } }
        [ForeignKey("Coop")]
        public int Id_Cooperativa { get; set; }
        public virtual Cooperativa Coop { get; set; } = null!;
    }
}
