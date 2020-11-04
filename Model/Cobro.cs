using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CobrosParcial.Model
{
    public class Cobro
    {
        [Key]
        public int CobroId { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoCobrado { get; set; }
        public string Observaciones { get; set; }
        [ForeignKey("ClienteId")]
        public int ClienteId { set; get; }
        public Clientes clientes { get; set; }
        [ForeignKey("CobroId")]
        public  virtual List<CobroDetalle> detalle { get; set; }
    }
}