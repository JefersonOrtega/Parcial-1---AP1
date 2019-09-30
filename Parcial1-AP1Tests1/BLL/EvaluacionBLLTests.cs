using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_AP1.BLL.Tests
{
    [TestClass()]
    public class EvaluacionBLLTests
    {
        [TestMethod()]
        public void CalcularPerdidoTest()
        {
            /*Evaluacion evaluacion = new Evaluacion();
            evaluacion = EvaluacionBLL.Buscar(8);
            evaluacion.valor = 31;
            evaluacion.logrado = 30;
            Assert.AreEqual(evaluacion.perdido,1);*/
           
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.IDEvaluacion = 0;
            evaluacion.Estudiante = "Juan Manuel";
            evaluacion.Fecha = DateTime.Now;
            evaluacion.valor = 31;
            evaluacion.logrado = 27;

            paso = EvaluacionBLL.Guardar(evaluacion);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Evaluacion evaluacion = new Evaluacion();

            evaluacion.IDEvaluacion = 2;
            evaluacion.Estudiante = "Juan Maria Perez";
            

            paso = EvaluacionBLL.Modificar(evaluacion);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            paso = EvaluacionBLL.Eliminar(4);
            Assert.AreEqual(paso, true);


        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            paso = EvaluacionBLL.Eliminar(5);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}