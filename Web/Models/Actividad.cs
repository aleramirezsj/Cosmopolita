﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Horarios { get; set; }
        [Required]
        [Precision(12, 2)]
        public decimal Costo { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
