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
    public partial class frmQuantoTempoPassou : Form
    {
        public frmQuantoTempoPassou()
        {
            InitializeComponent();
            calendarLeft.MaxDate = DateTime.Now;
            calenderRight.MinDate = DateTime.Now;
            calenderRight.MaxSelectionCount = 1;
            calendarLeft.MaxSelectionCount = 1;


        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            TimeSpan time=calenderRight.SelectionStart.Subtract(calendarLeft.SelectionStart);
            lblDias.Text = string.Format("{0} dias", time.Days);
        }
    }
}
