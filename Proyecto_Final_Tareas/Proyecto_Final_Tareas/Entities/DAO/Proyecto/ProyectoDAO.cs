using AGE.Utils;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Tareas.Entities.DAO.Proyecto
{
    public class ProyectoDAO
    {
        
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; } = null!;
        
        public DateOnly FechaInicio { get; set; }

        public DateOnly FechaFin { get; set; }

        public string Estado { get; set; } = null!;

        public virtual ICollection<TareaDAO> Tareas { get; set; } = new List<TareaDAO>();
    }
    
        
    

}
