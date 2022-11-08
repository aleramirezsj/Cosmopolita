﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Socio
    {
        [Key]
        public int Id { get; set; }
        //DataAnnotation: son anotaciones de Entity Framework que imponen restricciones en el motor de bases de datos
        [Required]
        public string Apellido_Nombre { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public override string ToString()
        {
            return Apellido_Nombre;
        }
    }
}
