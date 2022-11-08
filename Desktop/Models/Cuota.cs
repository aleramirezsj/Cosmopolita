using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Cuota
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Mes { get; set; }
        [Required]
        public int Año { get; set; }
        [Required]
        [Precision(12, 2)]
        public decimal Monto { get; set; }
        public bool Cobrada { get; set; }
        [Required]
        public DateTime Vencimiento { get; set; }
        public int SocioId { get; set; }
        [ForeignKey("SocioId")]
        public Socio Socio { get; set; }
        public int ActividadId { get; set; }
        [ForeignKey("ActividadId")]
        public Actividad Actividad { get; set; }
        public int CobradorId { get; set; }
        [ForeignKey("CobradorId")]
        public Cobrador Cobrador { get; set; }

    }
}
