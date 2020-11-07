using Microsoft.EntityFrameworkCore;
using System;
using CobrosParcial.Model;
using CobrosParcial.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CobrosParcial.BLL {
  public class ClienteBLL {
    public static List <Clientes> GetList(Expression <Func<Clientes, bool>> cliente) {
      List <Clientes> lista = new List <Clientes> ();
      Contexto db = new Contexto();
      try {

        lista = db.Cliente.Where(cliente).ToList();
      }
      catch(Exception) {
        throw;
      }
      finally {
        db.Dispose();
      }
      return lista;
    }

    public static List <Ventas> GetVentas(string ids) {
      int Id = Int32.Parse(ids);
      List <Ventas> lista = new List <Ventas> ();
      Contexto contexto = new Contexto();
      try {
        lista = contexto.Venta.Where(e =>e.ClienteId == Id).ToList();

      }
      catch(Exception) {
        throw;
      }
      finally {
        contexto.Dispose();
      }
      return lista;
    }

  }
}