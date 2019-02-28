namespace EX03
{
    partial class frmQueHorasSao
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
            this.progressHoras = new System.Windows.Forms.ProgressBar();
            this.progressMinutos = new System.Windows.Forms.ProgressBar();
            this.progressSegundos = new System.Windows.Forms.ProgressBar();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressHoras
            // 
            this.progressHoras.Location = new System.Drawing.Point(25, 33);
            this.progressHoras.Name = "progressHoras";
            this.progressHoras.Size = new System.Drawing.Size(127, 23);
            this.progressHoras.TabIndex = 0;
            // 
            // progressMinutos
            // 
            this.progressMinutos.Location = new System.Drawing.Point(25, 62);
            this.progressMinutos.Name = "progressMinutos";
            this.progressMinutos.Size = new System.Drawing.Size(373, 23);
            this.progressMinutos.TabIndex = 1;
            // 
            // progressSegundos
            // 
            this.progressSegundos.Location = new System.Drawing.Point(25, 91);
            this.progressSegundos.Name = "progressSegundos";
            this.progressSegundos.Size = new System.Drawing.Size(373, 23);
            this.progressSegundos.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(183, 33);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "label1";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(432, 62);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(35, 13);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "label2";
            this.lblMinutos.Click += new System.EventHandler(this.lblMinutos_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(432, 91);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(35, 13);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "label3";
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(25, 162);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(78, 17);
            this.radioAuto.TabIndex = 6;
            this.radioAuto.TabStop = true;
            this.radioAuto.Text = "Automático";
            this.radioAuto.UseVisualStyleBackColor = true;
            this.radioAuto.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // radioManual
            // 
            this.radioManual.AutoSize = true;
            this.radioManual.Location = new System.Drawing.Point(25, 185);
            this.radioManual.Name = "radioManual";
            this.radioManual.Size = new System.Drawing.Size(60, 17);
            this.radioManual.TabIndex = 7;
            this.radioManual.TabStop = true;
            this.radioManual.Text = "Manual";
            this.radioManual.UseVisualStyleBackColor = true;
            this.radioManual.CheckedChanged += new System.EventHandler(this.radioGeral_CheckedChanged);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(233, 190);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Atualizar";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // frmQueHorasSao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 248);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.radioManual);
            this.Controls.Add(this.radioAuto);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.progressSegundos);
            this.Controls.Add(this.progressMinutos);
            this.Controls.Add(this.progressHoras);
            this.Name = "frmQueHorasSao";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressHoras;
        private System.Windows.Forms.ProgressBar progressMinutos;
        private System.Windows.Forms.ProgressBar progressSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.Button BtnUpdate;
    }
}

