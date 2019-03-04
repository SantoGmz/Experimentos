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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncal
            // 
            this.btncal.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnseman.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.buttonCiclos.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(97, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "NuevosControles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(351, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.inicio_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.inicio_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnseman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCiclos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}