using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.Entidades
{
     public class Evaluacion
    {
        [Key]
        public int IDEvaluacion { get; set; }
        public string Estudiante { get; set; }
        public DateTime Fecha { get; set; }
        public float valor { get; set; }
        public float  logrado { get; set; }
        public float perdido { get; set; }
        public int pronostico { get; set; }
        

        public Evaluacion()
        {
            IDEvaluacion = 0;
            Estudiante = string.Empty;
            Fecha = DateTime.Now;
            valor = 0;
            logrado = 0;
            perdido = 0;
            pronostico = 0;
        }
    }
}
