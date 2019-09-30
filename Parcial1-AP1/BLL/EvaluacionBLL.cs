using Parcial1_AP1.DAL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL
{
    public class EvaluacionBLL
    {
        /// <summary>
        /// Metodo para calcular los puntos perdidos
        /// </summary>
        public static float CalcularPerdido(float valor, float logrado)
        {
            if (valor >= logrado)
                return (valor - logrado);
            else
                return 0;
        }

        public static bool Guardar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                if (db.Evaluacion.Add(evaluacion) != null)
                {
                    evaluacion.perdido = EvaluacionBLL.CalcularPerdido(evaluacion.valor, evaluacion.logrado);
                    paso = db.SaveChanges() > 0;
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Evaluacion evaluacion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(evaluacion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Evaluacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Evaluacion Buscar(int id)
        {
            Evaluacion evaluacion = new Evaluacion();
            Contexto db = new Contexto();

            try
            {
                evaluacion = db.Evaluacion.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return evaluacion;
        }

        public static List<Evaluacion> GetList(Expression<Func<Evaluacion,bool>> evaluacion)
        {
            List<Evaluacion> Lista = new List<Evaluacion>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Evaluacion.Where(evaluacion).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }
    }
}
