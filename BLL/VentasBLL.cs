using Microsoft.EntityFrameworkCore;
using System;
using CobrosParcial.Model;
using CobrosParcial.DAL;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CobrosParcial.BLL {
  public class VentasBLL {
    public static Ventas Buscar(int id) {
      Contexto contexto = new Contexto();
      Ventas venta;

      try {
        venta = contexto.Venta.Where(v =>v.VentaId == id).FirstOrDefault();
      } catch(Exception) {
        throw;
      } finally {
        contexto.Dispose();
      }

      return venta;
    }

    public async static Task <bool> Modificar(Ventas venta) {
      bool paso = false;
      Contexto contexto = new Contexto();

      try {
        contexto.Entry(venta).State = EntityState.Modified;

        paso = await contexto.SaveChangesAsync() > 0;

      } catch(Exception) {

        throw;
      } finally {
        await contexto.DisposeAsync();
      }
      return paso;
    }
  }
}