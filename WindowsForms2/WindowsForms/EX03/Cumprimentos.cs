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
    public partial class Cumprimentos : Form
    {
        public Cumprimentos()
        {
            InitializeComponent();
            this.Height = 128;
            this.Text = "Cumprimentos";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(msg.Text) || string.IsNullOrWhiteSpace(name.Text))
            {
                MessageBox.Show("Preencha todas as caixas", "Aviso!");
            }
            else
            {
                
                msgcmplt.Text = string.Format("{0} {1}",msg.Text , name.Text );
                clear.Enabled = true;
                this.Height = 204;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            msgcmplt.Text = "";
            this.Height = 128;
            msg.Clear();
            name.Clear();
        }
    }
}
