using Parcial1_AP1.BLL;
using Parcial1_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1.UI.Consultas
{
    public partial class cEvaluacion : Form
    {
        public cEvaluacion()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
           
            var listado = new List<Evaluacion>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: //Todo
                        {
                            listado = EvaluacionBLL.GetList(p => true);
                            break;
                        }

                    case 1: //Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = EvaluacionBLL.GetList(p => p.IDEvaluacion == id);
                            break;
                        }

                    case 3: //Nombre Estudiante
                        {
                            listado = EvaluacionBLL.GetList(p => p.Estudiante.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 4: //Perdido
                        {
                            float perdido = Convert.ToSingle(CriterioTextBox.Text);
                            listado = EvaluacionBLL.GetList(p => p.perdido == perdido);
                            break;
                        }

                    case 5: //Condicion
                        {
                            int criterio = 100000000; // un valor alto para que esa opcion nunca sea
                            if (CriterioTextBox.Text.ToLower() == "continuar")
                                criterio = 0;
                            else
                                if (CriterioTextBox.Text.ToLower() == "suspenso")
                                criterio = 1;
                            else
                                    if (CriterioTextBox.Text.ToLower() == "retirar")
                                criterio = 2;
                            
                           


                            listado = EvaluacionBLL.GetList(p => p.pronostico == criterio);
                            break;
                        }

                    
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = EvaluacionBLL.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
