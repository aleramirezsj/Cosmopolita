﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cobrador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Apellido_Nombre { get; set; }
    }
}
