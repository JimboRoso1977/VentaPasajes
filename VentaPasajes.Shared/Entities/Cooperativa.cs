using System.ComponentModel.DataAnnotations;

namespace VentaPasajes.Shared.Entities
{
    public class Cooperativa
    {
        [Key]
        public int Id_Cooperativa { get; set; }

        [Display(Name = "Nombre Empresa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "NIT de Empresa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nit { get; set; } = null!;

        [Display(Name = "Teléfono fijo o celular")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Telefono { get; set; } = null!;

        [Display(Name = "E-mail")]
        public string? Email { get; set; } = null;
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;
        public virtual ICollection<Oficina> Oficinas { get; set; } = null!;
    }
}
