using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace CobrosParcial.Model
{
    public class CobroDetalle
    {
         [Key]
        public int CobroDetalleId { get; set; }
        public double MontoVenta { get; set; }
        public double Cobrado{ get; set; }
        [ForeignKey("VentaId")]
        public int VentaId { set; get; }
        public int CobroId { set; get; }

        
        
    }
}