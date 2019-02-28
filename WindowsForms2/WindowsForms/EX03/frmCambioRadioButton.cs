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
    public partial class frmCambioRadioButton : Form
    {
        public frmCambioRadioButton()
        {
            InitializeComponent();
        }
        public enum Moedas
        {
            Dollar,Libra,Léne,SEK
        }

        private void convert_Click(object sender, EventArgs e)
        {
            RadioButton rb = groupMoeda.Controls.OfType<RadioButton>().FirstOrDefault(obj => obj.Checked == true);
            lblConversao.Text = string.Format("{0} {1}", converterMoeda(double.Parse(tbvalor.Text), (Moedas)Enum.Parse(typeof(Moedas),rb.Text)), rb.Text);            
        }
        public double converterMoeda(double valor,Moedas m)
        {
            switch (m)
            {
                case Moedas.Dollar: return Math.Round((valor * Properties.Settings.Default.dollar), 2);
                    break;
                case Moedas.Libra:
                    return Math.Round((valor * Properties.Settings.Default.libra), 2);
                    break;
                case Moedas.Léne:
                    return Math.Round((valor * Properties.Settings.Default.lene), 2);
                    break;
                case Moedas.SEK:
                    return Math.Round((valor * Properties.Settings.Default.sek), 2);
                    break;

            }
            return 0;
        }
    }
}
