namespace ProyectoSanto
{
    partial class diasemana
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
            this.bntver = new System.Windows.Forms.Button();
            this.textBoxdia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsexo = new System.Windows.Forms.TextBox();
            this.buttonverificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntver
            // 
            this.bntver.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntver.Location = new System.Drawing.Point(80, 80);
            this.bntver.Name = "bntver";
            this.bntver.Size = new System.Drawing.Size(127, 29);
            this.bntver.TabIndex = 0;
            this.bntver.Text = "ver";
            this.bntver.UseVisualStyleBackColor = true;
            this.bntver.Click += new System.EventHandler(this.bntver_Click);
            // 
            // textBoxdia
            // 
            this.textBoxdia.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdia.Location = new System.Drawing.Point(59, 41);
            this.textBoxdia.Multiline = true;
            this.textBoxdia.Name = "textBoxdia";
            this.textBoxdia.Size = new System.Drawing.Size(194, 32);
            this.textBoxdia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sexo";
            // 
            // textBoxsexo
            // 
            this.textBoxsexo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsexo.Location = new System.Drawing.Point(125, 169);
            this.textBoxsexo.MaxLength = 1;
            this.textBoxsexo.Multiline = true;
            this.textBoxsexo.Name = "textBoxsexo";
            this.textBoxsexo.Size = new System.Drawing.Size(82, 20);
            this.textBoxsexo.TabIndex = 3;
            this.textBoxsexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonverificar
            // 
            this.buttonverificar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonverificar.Location = new System.Drawing.Point(94, 215);
            this.buttonverificar.Name = "buttonverificar";
            this.buttonverificar.Size = new System.Drawing.Size(127, 31);
            this.buttonverificar.TabIndex = 4;
            this.buttonverificar.Text = "Verificar";
            this.buttonverificar.UseVisualStyleBackColor = true;
            this.buttonverificar.Click += new System.EventHandler(this.buttonverificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia";
            // 
            // diasemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(317, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonverificar);
            this.Controls.Add(this.textBoxsexo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxdia);
            this.Controls.Add(this.bntver);
            this.Font = new System.Drawing.Font("High Tower Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "diasemana";
            this.Text = "Dia de la semana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntver;
        private System.Windows.Forms.TextBox textBoxdia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsexo;
        private System.Windows.Forms.Button buttonverificar;
        private System.Windows.Forms.Label label2;
    }
}