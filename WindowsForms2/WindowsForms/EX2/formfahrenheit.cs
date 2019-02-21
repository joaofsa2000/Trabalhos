using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class formfahrenheit : Form
    {
        public formfahrenheit()
        {
            InitializeComponent();
            textBoxCel.ReadOnly=true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            
                textBoxCel.Text = string.Format("{0}",Math.Round((double.Parse(textBoxFah.Text)-32)/1.8));


            
        }
    }
}
