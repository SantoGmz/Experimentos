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
            this.buttonCiclos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncal.ForeColor = System.Drawing.Color.White;
            this.btncal.Location = new System.Drawing.Point(97, 109);
            this.btncal.Margin = new System.Windows.Forms.Padding(4);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(155, 34);
            this.btncal.TabIndex = 0;
            this.btncal.Text = "Calculadora";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnseman
            // 
            this.btnseman.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnseman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseman.ForeColor = System.Drawing.Color.White;
            this.btnseman.Location = new System.Drawing.Point(97, 151);
            this.btnseman.Margin = new System.Windows.Forms.Padding(4);
            this.btnseman.Name = "btnseman";
            this.btnseman.Size = new System.Drawing.Size(155, 34);
            this.btnseman.TabIndex = 1;
            this.btnseman.Text = "Dia De Semana";
            this.btnseman.UseVisualStyleBackColor = false;
            this.btnseman.Click += new System.EventHandler(this.btnseman_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(97, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Operadores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCiclos
            // 
            this.buttonCiclos.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonCiclos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCiclos.ForeColor = System.Drawing.Color.White;
            this.buttonCiclos.Location = new System.Drawing.Point(97, 240);
            this.buttonCiclos.Name = "buttonCiclos";
            this.buttonCiclos.Size = new System.Drawing.Size(155, 38);
            this.buttonCiclos.TabIndex = 3;
            this.buttonCiclos.Text = "Ciclos";
            this.buttonCiclos.UseVisualStyleBackColor = false;
            this.buttonCiclos.Click += new System.EventHandler(this.buttonCiclos_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(97, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inicio Session";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(351, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCiclos);
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
        private System.Windows.Forms.Button buttonCiclos;
        private System.Windows.Forms.Button button2;
    }
}