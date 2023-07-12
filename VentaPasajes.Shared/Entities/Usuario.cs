using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }

        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "El campo {0} es oblihgatorio.")]
        public string Nombre_Completo { get; set; } = null!;

        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; } = null!;

        [Display(Name = "Usuario")]
        public string Nombre_Usuario { get; set; } = null!;
        public DateTime Fecha_Registro { get; set; }

        [Display(Name = "Nro. Celular")]
        public string Celular { get; set; } = null!;

        [Display(Name = "Correo Electronico")]
        public string Email { get; set; } = null!;
        public string Codigo_Empledo { get { return "EMP-" + Id_Usuario.ToString(); } }

        [ForeignKey("Ofi")]
        public int Id_Oficina { get; set; }
        public virtual Oficina Ofi { get; set; } = null!;


    }
}
