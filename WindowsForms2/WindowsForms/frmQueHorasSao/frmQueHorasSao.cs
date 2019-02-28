using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX03
{
    public partial class frmQueHorasSao : Form
    {
        Timer tempo;
        public frmQueHorasSao()
        {
            InitializeComponent();
            progressHoras.Maximum = 23;
            progressMinutos.Maximum = 59;
            progressSegundos.Maximum = 59;
            tempo = new Timer();
            tempo.Tick += Tempo_Tick;
            tempo.Interval = 1000;
            tempo.Start();
            radioAuto.Checked = true;
            BtnUpdate.Enabled = false;

        }

        private void lblMinutos_Click(object sender, EventArgs e)
        {

        }
        private void Tempo_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            progressHoras.Value = data.Hour;
            progressMinutos.Value = data.Minute;
            progressSegundos.Value = data.Second;
            lblHoras.Text = data.Hour.ToString() + " hora" + (data.Hour == 1 ? "" : "s");
            lblMinutos.Text = data.Minute.ToString() + " minuto" + (data.Minute == 1 ? "" : "s");
            lblSegundos.Text = data.Second.ToString() + " segundo" + (data.Second == 1 ? "" : "s");

        }

        private void radioGeral_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAuto.Checked)
            {
                tempo.Start();
                BtnUpdate.Enabled = false;
            }
            else
            {
                tempo.Stop();
                BtnUpdate.Enabled = true;
            }
        }

        private void radioManual_CheckedChanged(object sender, EventArgs e)
        {
            BtnUpdate.Enabled = radioManual.Checked;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Tempo_Tick(null, null);
        }
    }
}
