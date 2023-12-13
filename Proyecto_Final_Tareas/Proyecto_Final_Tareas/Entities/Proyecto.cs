﻿using AGE.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Proyecto_Final_Tareas.Entities;

public partial class Proyecto
{
    [Key]
    [Column("Id")]
    [Required(ErrorMessage = "El código del proyecto no puede ser nulo.")]
    public int Id { get; set; }

    [Column("Nombre")]
    [Required(ErrorMessage = "El nombre del proyecto no puede ser nulo.")]
    [StringLength(100, ErrorMessage = "El nombre del proyecto no debe sobrepasar los 100 caracteres.")]
    public string Nombre { get; set; } = null!;

    [Column("Descripcion")]
    [Required(ErrorMessage = "La descripcion del proyecto no puede ser nula.")]
    [StringLength(255, ErrorMessage = "La descripcion del proyecto no puede superar los 255 caracteres.")]
    public string? Descripcion { get; set; } = null!;
    [Column("FechaInicio")]
    [Required(ErrorMessage = "La fecha de inicio no puede ser nula.")]
    public DateOnly FechaInicio { get; set; }

    [Column("FechaFin")]
    [Required(ErrorMessage = "La fecha de fin no puede ser nula.")]
    public DateOnly FechaFin { get; set; }

    [Required(ErrorMessage = "El estado no puede ser nulo.")]
    [Column("estado")]
    [RegularExpression("^[AI]$", ErrorMessage = $"El campo estado debe ser {Globales.ESTADO_ACTIVO} o {Globales.ESTADO_INACTIVO}.")]
    public string Estado { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Tarea> Tareas { get; set; } = new List<Tarea>();
}
