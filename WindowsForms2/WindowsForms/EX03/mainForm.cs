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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Exec_Cumpr_Click(object sender, EventArgs e)
        {
            Cumprimentos cump = this.MdiChildren.FirstOrDefault(obj => obj.GetType()==typeof(Cumprimentos))as Cumprimentos;
            if (cump == null)
            {
                cump = new Cumprimentos();
                cump.MdiParent = this;                
            }
            cump.Show();
        }

        private void Exec_CalcNota_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.FirstOrDefault(obj => obj.GetType() == typeof(CalcNota)) is CalcNota calNota))
            {
                calNota = new CalcNota() { MdiParent=this};                
            }
            calNota.Show();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(this.MdiChildren.FirstOrDefault(obj => obj.GetType()==typeof(NomeEmail))is NomeEmail nm))
            {
                nm = new NomeEmail() { MdiParent = this };
            }
            nm.Show();
        }
        private void queHorasSaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.FirstOrDefault(obj => obj.GetType() == typeof(frmQueHorasSao)) is frmQueHorasSao horas))
            {
                horas = new frmQueHorasSao() { MdiParent = this };
            }
            horas.Show();
        }
        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.FirstOrDefault(obj => obj.GetType() == typeof(frmQuantoTempoPassou)) is frmQuantoTempoPassou tempo))
            {
                tempo = new frmQuantoTempoPassou() { MdiParent = this };
            }
            tempo.Show();
        }
        private void cambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(this.MdiChildren.FirstOrDefault(obj => obj.GetType() == typeof(frmCambioRadioButton)) is frmCambioRadioButton cambio))
            {
                cambio = new frmCambioRadioButton() { MdiParent = this };
            }
            cambio.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }


    }
}
