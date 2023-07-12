using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace VentaPasajes.Shared.Entities
{
    public class Premio
    {
        [Key]
        public int Id_Premio { get; set; }

        [Display(Name = "Nombre del Premio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Nombre_Premio { get; set; } = null!;

        [ForeignKey("Sort")]
        public int Id_Sorteo { get; set; }
        public virtual required Datos_Sorteo Sort { get; set; }
    }
}
