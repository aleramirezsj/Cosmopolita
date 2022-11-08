using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelos
{
    public class Inscripto
    {
        [Key]
        public int Id { get; set; }
        public int SocioId { get; set; }
        [ForeignKey("SocioId")]
        public Socio Socio { get; set; }
        public int ActividadId { get; set; }
        [ForeignKey("ActividadId")]
        public Actividad Actividad { get; set; }
    }
}
