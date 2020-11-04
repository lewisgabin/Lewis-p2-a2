using Microsoft.EntityFrameworkCore;
using CobrosParcial.DAL;
using CobrosParcial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace CobrosParcial.BLL
{
    public class CobrosBLL
    {
         public static bool Guardar(Cobro cobro)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Cobro.Add(cobro);
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

         public static Cobro Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cobro cobro = new Cobro();

            try
            {
                cobro = contexto.Cobro
                    .Where(e => e.CobroId == id)
                    .Include(e => e.detalle)
                    .FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return cobro;
        }
    }
}