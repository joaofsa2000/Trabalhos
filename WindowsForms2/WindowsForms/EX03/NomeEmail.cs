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
    public partial class NomeEmail : Form
    {
        public NomeEmail()
        {
            InitializeComponent();
            Height = 200;
        }

        private void nameKeypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Não é permitido números");
                e.Handled = true;
            }
        }

        private void verButton_Click(object sender, EventArgs e)
        {
            Height = 530;

        }
        private string[] nomecortado(string nome)
        {
            string[] corte = nome.Split(' ');
            return new string[] { corte[0], corte[corte.Length - 1] };
        }
        private string nomereduzido(string nome)
        {
            string[] corte = nome.Split(' ');
            return string.Format("{0} {1}", corte[0], corte[corte.Length - 1]);
        }
        private string email1(string nome)
        {
            string[] corte = nome.Split(' ');
            return string.Format("{0}.{1}@xpto.pt", corte[0], corte[corte.Length - 1]);
        }

    }
}
