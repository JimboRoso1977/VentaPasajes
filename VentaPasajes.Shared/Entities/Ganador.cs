using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaPasajes.Shared.Entities
{
    public class Ganador
    {
        [Key]
        public int Id_Ganador { get; set; }

        [Display(Name = "Nombre del Ganador")]
        [Required(ErrorMessage = "El campo {0} es oblihgatorio.")]
        public string Nombre_Ganador { get; set; } = null!;

        [Display(Name = "Nombre del Sorte")]
        [Required(ErrorMessage = "El campo {0} es oblihgatorio.")]
        public string Nombre_Sorteo { get; set; } = null!;

        [Display(Name = "Nombre del Premio")]
        [Required(ErrorMessage = "El campo {0} es oblihgatorio.")]
        public string Nombre_Premio { get; set; } = null!;

        public DateTime Fecha_Sorteo { get; set; }
        public DateTime Fecha_Registro { get; set; } = DateTime.Now;

    }
}
