using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CobrosParcial.Model
{
    public class Ventas
    {
        
        [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        [ForeignKey("ClienteId")]
        public int ClienteId { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}