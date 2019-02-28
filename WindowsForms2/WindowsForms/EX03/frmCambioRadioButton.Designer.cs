namespace EX03
{
    partial class frmCambioRadioButton
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
            this.tbvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioDollar = new System.Windows.Forms.RadioButton();
            this.groupMoeda = new System.Windows.Forms.GroupBox();
            this.radioSEK = new System.Windows.Forms.RadioButton();
            this.radioLene = new System.Windows.Forms.RadioButton();
            this.radioLibra = new System.Windows.Forms.RadioButton();
            this.convert = new System.Windows.Forms.Button();
            this.lblConversao = new System.Windows.Forms.Label();
            this.groupMoeda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbvalor
            // 
            this.tbvalor.Location = new System.Drawing.Point(42, 64);
            this.tbvalor.Name = "tbvalor";
            this.tbvalor.Size = new System.Drawing.Size(100, 20);
            this.tbvalor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // radioDollar
            // 
            this.radioDollar.AutoSize = true;
            this.radioDollar.Location = new System.Drawing.Point(19, 19);
            this.radioDollar.Name = "radioDollar";
            this.radioDollar.Size = new System.Drawing.Size(52, 17);
            this.radioDollar.TabIndex = 2;
            this.radioDollar.TabStop = true;
            this.radioDollar.Text = "Dollar";
            this.radioDollar.UseVisualStyleBackColor = true;
            // 
            // groupMoeda
            // 
            this.groupMoeda.Controls.Add(this.radioSEK);
            this.groupMoeda.Controls.Add(this.radioLene);
            this.groupMoeda.Controls.Add(this.radioLibra);
            this.groupMoeda.Controls.Add(this.radioDollar);
            this.groupMoeda.Location = new System.Drawing.Point(177, 30);
            this.groupMoeda.Name = "groupMoeda";
            this.groupMoeda.Size = new System.Drawing.Size(121, 128);
            this.groupMoeda.TabIndex = 3;
            this.groupMoeda.TabStop = false;
            this.groupMoeda.Text = "Moeda";
            // 
            // radioSEK
            // 
            this.radioSEK.AutoSize = true;
            this.radioSEK.Location = new System.Drawing.Point(19, 88);
            this.radioSEK.Name = "radioSEK";
            this.radioSEK.Size = new System.Drawing.Size(46, 17);
            this.radioSEK.TabIndex = 5;
            this.radioSEK.TabStop = true;
            this.radioSEK.Text = "SEK";
            this.radioSEK.UseVisualStyleBackColor = true;
            // 
            // radioLene
            // 
            this.radioLene.AutoSize = true;
            this.radioLene.Location = new System.Drawing.Point(19, 65);
            this.radioLene.Name = "radioLene";
            this.radioLene.Size = new System.Drawing.Size(49, 17);
            this.radioLene.TabIndex = 4;
            this.radioLene.TabStop = true;
            this.radioLene.Text = "Léne";
            this.radioLene.UseVisualStyleBackColor = true;
            // 
            // radioLibra
            // 
            this.radioLibra.AutoSize = true;
            this.radioLibra.Location = new System.Drawing.Point(19, 42);
            this.radioLibra.Name = "radioLibra";
            this.radioLibra.Size = new System.Drawing.Size(48, 17);
            this.radioLibra.TabIndex = 3;
            this.radioLibra.TabStop = true;
            this.radioLibra.Text = "Libra";
            this.radioLibra.UseVisualStyleBackColor = true;
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(42, 95);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(100, 23);
            this.convert.TabIndex = 4;
            this.convert.Text = "Converter";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // lblConversao
            // 
            this.lblConversao.AutoSize = true;
            this.lblConversao.Location = new System.Drawing.Point(39, 145);
            this.lblConversao.Name = "lblConversao";
            this.lblConversao.Size = new System.Drawing.Size(35, 13);
            this.lblConversao.TabIndex = 5;
            this.lblConversao.Text = "label2";
            // 
            // frmCambioRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 185);
            this.Controls.Add(this.lblConversao);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.groupMoeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbvalor);
            this.Name = "frmCambioRadioButton";
            this.Text = "frmCambioRadioButton";
            this.groupMoeda.ResumeLayout(false);
            this.groupMoeda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbvalor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioDollar;
        private System.Windows.Forms.GroupBox groupMoeda;
        private System.Windows.Forms.RadioButton radioSEK;
        private System.Windows.Forms.RadioButton radioLene;
        private System.Windows.Forms.RadioButton radioLibra;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Label lblConversao;
    }
}