namespace EX03
{
    partial class Cumprimentos
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
            this.msg = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.msgcmplt = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(24, 28);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(100, 20);
            this.msg.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(24, 54);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(130, 40);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Clique";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // msgcmplt
            // 
            this.msgcmplt.AutoSize = true;
            this.msgcmplt.Location = new System.Drawing.Point(24, 98);
            this.msgcmplt.Name = "msgcmplt";
            this.msgcmplt.Size = new System.Drawing.Size(0, 13);
            this.msgcmplt.TabIndex = 3;
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(78, 130);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "Limpar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Cumprimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 165);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.msgcmplt);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.name);
            this.Controls.Add(this.msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cumprimentos";
            this.Text = "Cumprimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Label msgcmplt;
        private System.Windows.Forms.Button clear;
    }
}