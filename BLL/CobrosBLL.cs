using Microsoft.EntityFrameworkCore;
using CobrosParcial.DAL;
using CobrosParcial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CobrosParcial.BLL {
  public class CobrosBLL {
    public static bool Guardar(Cobro cobro) {
      bool paso = false;
      Contexto contexto = new Contexto();

      try {
        contexto.Cobro.Add(cobro);
        paso = (contexto.SaveChanges() > 0);
        if (paso) {
          foreach(var cobroDetalle in cobro.detalle) {
            var venta = VentasBLL.Buscar(cobroDetalle.VentaId);
            if (venta != null) {
              venta.Balance -= cobroDetalle.Cobrado;
              VentasBLL.Modificar(venta);
            }
          }
        }
      }
      catch(Exception) {

        throw;
      }
      finally {
        contexto.Dispose();
      }
      return paso;
    }

    public static Cobro Buscar(int id) {
      Contexto contexto = new Contexto();
      Cobro cobro = new Cobro();

      try {
        cobro = contexto.Cobro.Where(e =>e.CobroId == id).Include(e =>e.detalle).FirstOrDefault();
      }
      catch(Exception) {
        throw;
      }
      finally {
        contexto.Dispose();
      }

      return cobro;
    }

    public static bool Eliminar(int id) {
      bool paso = false;
      Contexto contexto = new Contexto();
      try {
        var cobro = Buscar(id);

        if (cobro != null) {
          contexto.Cobro.Remove(cobro);
          paso = contexto.SaveChanges() > 0;

          if (paso) {
            foreach(var cobroDetalle in cobro.detalle) {
              var venta = VentasBLL.Buscar(cobroDetalle.VentaId);
              if (venta != null) {
                venta.Balance += cobroDetalle.Cobrado;
                VentasBLL.Modificar(venta);
              }
            }
          }
        }
      } catch(Exception) {
        throw;
      } finally {
        contexto.Dispose();
      }

      return paso;
    }

    public static List < Ventas > GetVentas() {
      List < Ventas > lista = new List < Ventas > ();
      Contexto contexto = new Contexto();
      try {
        lista = contexto.Venta.ToList();

      }
      catch(Exception) {
        throw;
      }
      finally {
        contexto.Dispose();
      }
      return lista;
    }

    public static List < Cobro > GetCobros() {
      Contexto contexto = new Contexto();

      List < Cobro > cobros = new List < Cobro > ();

      try {
        cobros = contexto.Cobro.Include(c =>c.detalle).ToList();
      } catch(Exception) {

        throw;
      } finally {
        contexto.Dispose();
      }

      return cobros;

    }
  }
}