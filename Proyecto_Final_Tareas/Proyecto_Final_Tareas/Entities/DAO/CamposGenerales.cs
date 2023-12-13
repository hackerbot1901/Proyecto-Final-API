using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Tareas.Entities.DAO
{
    public class CamposGenerales
    {
        public string Estado { get; set; }
        public DateTime FechaEstado { get; set; }
        public string? ObservacionEstado { get; set; }

        [Required(ErrorMessage = "El campo usuario ingreso no puede ser nulo.")]
        [RegularExpression("^[1-9]\\d*$", ErrorMessage = "El campo usuario ingreso debe ser un número entero mayor a cero.")]
        public long UsuarioIngreso { get; set; }

        public DateTime FechaIngreso { get; set; }

        public string? UbicacionIngreso { get; set; }

        public long? UsuarioModificacion { get; set; }

        public DateTime? FechaModificacion { get; set; }


        public string? UbicacionModificacion { get; set; }
    }
}


