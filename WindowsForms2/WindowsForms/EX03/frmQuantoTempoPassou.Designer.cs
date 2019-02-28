namespace EX03
{
    partial class frmQuantoTempoPassou
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarLeft = new System.Windows.Forms.MonthCalendar();
            this.calenderRight = new System.Windows.Forms.MonthCalendar();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblMeses = new System.Windows.Forms.Label();
            this.lblAnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendarLeft
            // 
            this.calendarLeft.Location = new System.Drawing.Point(76, 101);
            this.calendarLeft.Name = "calendarLeft";
            this.calendarLeft.TabIndex = 0;
            // 
            // calenderRight
            // 
            this.calenderRight.Location = new System.Drawing.Point(369, 101);
            this.calenderRight.Name = "calenderRight";
            this.calenderRight.TabIndex = 1;
            this.calenderRight.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(630, 101);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "label1";
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(630, 115);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(35, 13);
            this.lblMeses.TabIndex = 3;
            this.lblMeses.Text = "label2";
            // 
            // lblAnos
            // 
            this.lblAnos.AutoSize = true;
            this.lblAnos.Location = new System.Drawing.Point(630, 129);
            this.lblAnos.Name = "lblAnos";
            this.lblAnos.Size = new System.Drawing.Size(35, 13);
            this.lblAnos.TabIndex = 4;
            this.lblAnos.Text = "label3";
            // 
            // frmQuantoTempoPassou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnos);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.calenderRight);
            this.Controls.Add(this.calendarLeft);
            this.Name = "frmQuantoTempoPassou";
            this.Text = "frmQuantoTempoPassou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarLeft;
        private System.Windows.Forms.MonthCalendar calenderRight;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.Label lblAnos;
    }
}