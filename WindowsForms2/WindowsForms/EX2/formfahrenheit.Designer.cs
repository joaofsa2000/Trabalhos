namespace App2
{
    partial class formfahrenheit
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
            this.textBoxFah = new System.Windows.Forms.TextBox();
            this.textBoxCel = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.novoCalculo = new System.Windows.Forms.Button();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFah
            // 
            this.textBoxFah.Location = new System.Drawing.Point(126, 34);
            this.textBoxFah.Name = "textBoxFah";
            this.textBoxFah.Size = new System.Drawing.Size(100, 20);
            this.textBoxFah.TabIndex = 0;
            // 
            // textBoxCel
            // 
            this.textBoxCel.Location = new System.Drawing.Point(126, 96);
            this.textBoxCel.Name = "textBoxCel";
            this.textBoxCel.Size = new System.Drawing.Size(100, 20);
            this.textBoxCel.TabIndex = 1;
            // 
            // calcular
            // 
            this.calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcular.Location = new System.Drawing.Point(126, 60);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(100, 23);
            this.calcular.TabIndex = 2;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // novoCalculo
            // 
            this.novoCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.novoCalculo.Location = new System.Drawing.Point(126, 122);
            this.novoCalculo.Name = "novoCalculo";
            this.novoCalculo.Size = new System.Drawing.Size(100, 23);
            this.novoCalculo.TabIndex = 3;
            this.novoCalculo.Text = "Novo Calculo";
            this.novoCalculo.UseVisualStyleBackColor = true;
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitLabel.Location = new System.Drawing.Point(33, 33);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(77, 18);
            this.fahrenheitLabel.TabIndex = 4;
            this.fahrenheitLabel.Text = "Fahrenheit";
            this.fahrenheitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusLabel.Location = new System.Drawing.Point(33, 96);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(57, 18);
            this.CelsiusLabel.TabIndex = 5;
            this.CelsiusLabel.Text = "Celsius";
            // 
            // formfahrenheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 163);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.novoCalculo);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.textBoxCel);
            this.Controls.Add(this.textBoxFah);
            this.Name = "formfahrenheit";
            this.Text = "formfahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFah;
        private System.Windows.Forms.TextBox textBoxCel;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button novoCalculo;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.Label CelsiusLabel;
    }
}