using Parcial1_AP1.BLL;
using Parcial1_AP1.DAL;
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

namespace Parcial1_AP1.UI.Registros
{
    public partial class rEvaluacion : Form
    {
        public rEvaluacion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDEvaluacionnumericUpDown.Value = 0;
            EstudiantetextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            ValortextBox.Text = string.Empty;
            LogradotextBox.Text = string.Empty;
            PerdidotextBox.Text = string.Empty;
            PronosticocomboBox.Text = string.Empty;
            MyerrorProvider.Clear();

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarCampos(Evaluacion evaluacion)
        {
            IDEvaluacionnumericUpDown.Value = evaluacion.IDEvaluacion;
            EstudiantetextBox.Text = evaluacion.Estudiante;
            FechadateTimePicker.Value = evaluacion.Fecha;
            ValortextBox.Text = Convert.ToString(evaluacion.valor);
            LogradotextBox.Text = Convert.ToString(evaluacion.logrado);
            PerdidotextBox.Text = Convert.ToString(evaluacion.perdido);
            PronosticocomboBox.SelectedItem = evaluacion.pronostico;
        }

        private Evaluacion LLenarClase()
        {
            Evaluacion evaluacion = new Evaluacion();
            evaluacion.IDEvaluacion = Convert.ToInt32(IDEvaluacionnumericUpDown.Value);
            evaluacion.Estudiante = EstudiantetextBox.Text;
            evaluacion.Fecha = FechadateTimePicker.Value;
            evaluacion.valor = Convert.ToSingle(ValortextBox.Text);
            evaluacion.logrado = Convert.ToSingle(LogradotextBox.Text);
            evaluacion.perdido = Convert.ToSingle(PerdidotextBox.Text);
            evaluacion.pronostico = Convert.ToInt32(PronosticocomboBox.SelectedIndex);

            return evaluacion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Evaluacion evaluacion = EvaluacionBLL.Buscar((int)IDEvaluacionnumericUpDown.Value);

            return evaluacion != null;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyerrorProvider.SetError(EstudiantetextBox, "No se puede dejar este campo vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                MyerrorProvider.SetError(ValortextBox, "No se puede dejar este campo vacio");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                MyerrorProvider.SetError(LogradotextBox, "No se puede dejar este campo vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PerdidotextBox.Text))
            {
                MyerrorProvider.SetError(PerdidotextBox, "No se puede dejar este campo vacio");
                paso = false;
            }
            return paso;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            Evaluacion evaluacion;

            if (!Validar())
                return;

            evaluacion = LLenarClase();

            if (IDEvaluacionnumericUpDown.Value == 0)
            {
                paso = EvaluacionBLL.Guardar(evaluacion);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una evaluacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EvaluacionBLL.Modificar(evaluacion);
            }

            if (paso)
            {
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se ha podido Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            MyerrorProvider.Clear();

            int.TryParse(IDEvaluacionnumericUpDown.Text, out id);
            Limpiar();
            if (EvaluacionBLL.Eliminar(id))
            {
                MessageBox.Show("ELiminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(IDEvaluacionnumericUpDown, "No se puede eliminar una evaluacion que no exite");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Evaluacion evaluacion = new Evaluacion();
            int id;

            int.TryParse(IDEvaluacionnumericUpDown.Text, out id);

            evaluacion = EvaluacionBLL.Buscar(id);

            if (evaluacion != null)
            {
                MessageBox.Show("Encontrado");
                LlenarCampos(evaluacion);
            }
            else
            {
                MessageBox.Show("No encontrado");
            }
        }

        private void ValortextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LogradotextBox.Text))
            {
                LogradotextBox.Text = "0";
            }
            float logrado;
            float.TryParse(LogradotextBox.Text, out logrado);

            float valor;
            float.TryParse(ValortextBox.Text, out valor);

            float perdido = EvaluacionBLL.CalcularPerdido(valor, logrado);

            PerdidotextBox.Text = Convert.ToString(perdido);

            if ((perdido * 31 / 10) < 25)
            {
                PronosticocomboBox.SelectedIndex = 0;
            }
            else
            {
                if (((perdido * 31 / 10) >= 25) & ((perdido * 31 / 10) <= 25))
                    PronosticocomboBox.SelectedIndex = 1;
                else
                {
                    if ((perdido * 31 / 10) > 25)
                    {
                        PronosticocomboBox.SelectedIndex = 2;
                    }
                }
            }
            
        }

        private void LogradotextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ValortextBox.Text))
            {
                ValortextBox.Text = "0";
            }

            float logrado;
            float.TryParse(LogradotextBox.Text, out logrado);

            float valor;
            float.TryParse(ValortextBox.Text, out valor);

            float perdido = EvaluacionBLL.CalcularPerdido(valor, logrado);

            PerdidotextBox.Text = Convert.ToString(perdido);

            if((perdido * 31 / 10) < 25)
            {
                PronosticocomboBox.SelectedIndex = 0;
            }
            else
            {
                if (((perdido * 31 / 10) >= 25) & ((perdido * 31 / 10) <= 25))
                    PronosticocomboBox.SelectedIndex = 1;
                else
                {
                    if ((perdido * 31 / 10) > 25)
                    {
                        PronosticocomboBox.SelectedIndex = 2;
                    }
                }
            }

        }
    }
}
