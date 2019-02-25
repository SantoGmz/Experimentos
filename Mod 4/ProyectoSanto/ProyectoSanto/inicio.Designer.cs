namespace ProyectoSanto
{
    partial class inicio
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
            this.btncal = new System.Windows.Forms.Button();
            this.btnseman = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncal.Location = new System.Drawing.Point(129, 109);
            this.btncal.Margin = new System.Windows.Forms.Padding(4);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(100, 34);
            this.btncal.TabIndex = 0;
            this.btncal.Text = "Calculadora";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnseman
            // 
            this.btnseman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseman.Location = new System.Drawing.Point(97, 151);
            this.btnseman.Margin = new System.Windows.Forms.Padding(4);
            this.btnseman.Name = "btnseman";
            this.btnseman.Size = new System.Drawing.Size(155, 34);
            this.btnseman.TabIndex = 1;
            this.btnseman.Text = "Dia De Semana";
            this.btnseman.UseVisualStyleBackColor = true;
            this.btnseman.Click += new System.EventHandler(this.btnseman_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(97, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Operadores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(351, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnseman);
            this.Controls.Add(this.btncal);
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inicio";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Deactivate += new System.EventHandler(this.inicio_Deactivate);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inicio_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnseman;
        private System.Windows.Forms.Button button1;
    }
}