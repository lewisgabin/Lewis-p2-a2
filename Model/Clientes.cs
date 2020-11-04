using System.ComponentModel.DataAnnotations;
namespace CobrosParcial.Model
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
    }
}