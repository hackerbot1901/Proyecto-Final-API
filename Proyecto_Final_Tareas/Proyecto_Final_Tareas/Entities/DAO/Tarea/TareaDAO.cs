using AGE.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_Final_Tareas.Entities;

public class TareaDAO
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; } = null!;
   
    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }
    public string Estado { get; set; } = null!;
   
    public int ProyectoId { get; set; }

    public virtual Proyecto Proyecto { get; set; } = null!;
}
