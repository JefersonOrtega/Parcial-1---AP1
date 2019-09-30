using Parcial1_AP1.UI.Consultas;
using Parcial1_AP1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEvaluacion rEvaluacion = new rEvaluacion();
            rEvaluacion.MdiParent = this;
            rEvaluacion.Show();
        }

        private void EvaluacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEvaluacion cEvaluacion = new cEvaluacion();
            cEvaluacion.MdiParent = this;
            cEvaluacion.Show();
        }
    }
}
