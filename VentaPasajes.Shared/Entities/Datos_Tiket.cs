using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VentaPasajes.Shared.Entities
{
    public class Datos_Tiket
    {
        [Key]
        public int Id_Tiket { get; set; }

        [ForeignKey("Sort")]
        public int Id_Sorteo { get; set; }
        public virtual Datos_Sorteo Sort { get; set; } = null!;

        [ForeignKey("Clie")]
        public int Id_Cliente { get; set; }
        public virtual Cliente Cliente { get; set; } = null!;

        public string Codigo_Tiket { get { return "NRO-" + Id_Sorteo.ToString() + "-" + Id_Cliente.ToString() + "-" + Id_Tiket; } }

    }
}