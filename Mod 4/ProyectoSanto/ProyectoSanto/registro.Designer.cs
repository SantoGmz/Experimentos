﻿namespace ProyectoSanto
{
    partial class registro
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpasswd = new System.Windows.Forms.Label();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxapellido = new System.Windows.Forms.TextBox();
            this.textBoxcorreo = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.textBoxpasswd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblpasswd2 = new System.Windows.Forms.Label();
            this.textBoxpasswd2 = new System.Windows.Forms.TextBox();
            this.lblgenero = new System.Windows.Forms.Label();
            this.rbsexohombre = new System.Windows.Forms.RadioButton();
            this.rbsexomujer = new System.Windows.Forms.RadioButton();
            this.lblpais = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.comboBoxestado = new System.Windows.Forms.ComboBox();
            this.checkBoxterminos = new System.Windows.Forms.CheckBox();
            this.buttonsave = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblnombre.Location = new System.Drawing.Point(32, 32);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblapellido.Location = new System.Drawing.Point(32, 88);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(58, 16);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblfecha.Location = new System.Drawing.Point(32, 184);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(138, 16);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "Fecha De Nacimiento";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcorreo.Location = new System.Drawing.Point(32, 133);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(49, 16);
            this.lblcorreo.TabIndex = 3;
            this.lblcorreo.Text = "Correo";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbluser.Location = new System.Drawing.Point(32, 236);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(55, 16);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "Usuario";
            // 
            // lblpasswd
            // 
            this.lblpasswd.AutoSize = true;
            this.lblpasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpasswd.Location = new System.Drawing.Point(32, 288);
            this.lblpasswd.Name = "lblpasswd";
            this.lblpasswd.Size = new System.Drawing.Size(77, 16);
            this.lblpasswd.TabIndex = 5;
            this.lblpasswd.Text = "Contraseña";
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(35, 51);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxnombre.TabIndex = 6;
            // 
            // textBoxapellido
            // 
            this.textBoxapellido.Location = new System.Drawing.Point(35, 107);
            this.textBoxapellido.Name = "textBoxapellido";
            this.textBoxapellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxapellido.TabIndex = 7;
            this.textBoxapellido.TextChanged += new System.EventHandler(this.textBoxapellido_TextChanged);
            // 
            // textBoxcorreo
            // 
            this.textBoxcorreo.Location = new System.Drawing.Point(35, 152);
            this.textBoxcorreo.Name = "textBoxcorreo";
            this.textBoxcorreo.Size = new System.Drawing.Size(100, 20);
            this.textBoxcorreo.TabIndex = 9;
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(35, 255);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(100, 20);
            this.textBoxuser.TabIndex = 10;
            // 
            // textBoxpasswd
            // 
            this.textBoxpasswd.Location = new System.Drawing.Point(35, 307);
            this.textBoxpasswd.Name = "textBoxpasswd";
            this.textBoxpasswd.Size = new System.Drawing.Size(100, 20);
            this.textBoxpasswd.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblpasswd2
            // 
            this.lblpasswd2.AutoSize = true;
            this.lblpasswd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasswd2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpasswd2.Location = new System.Drawing.Point(32, 341);
            this.lblpasswd2.Name = "lblpasswd2";
            this.lblpasswd2.Size = new System.Drawing.Size(118, 16);
            this.lblpasswd2.TabIndex = 13;
            this.lblpasswd2.Text = "Repita contraseña";
            // 
            // textBoxpasswd2
            // 
            this.textBoxpasswd2.Location = new System.Drawing.Point(35, 360);
            this.textBoxpasswd2.Name = "textBoxpasswd2";
            this.textBoxpasswd2.Size = new System.Drawing.Size(100, 20);
            this.textBoxpasswd2.TabIndex = 14;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblgenero.Location = new System.Drawing.Point(284, 32);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(53, 16);
            this.lblgenero.TabIndex = 15;
            this.lblgenero.Text = "Genero";
            // 
            // rbsexohombre
            // 
            this.rbsexohombre.AutoSize = true;
            this.rbsexohombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsexohombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbsexohombre.Location = new System.Drawing.Point(284, 52);
            this.rbsexohombre.Name = "rbsexohombre";
            this.rbsexohombre.Size = new System.Drawing.Size(70, 19);
            this.rbsexohombre.TabIndex = 16;
            this.rbsexohombre.TabStop = true;
            this.rbsexohombre.Text = "Hombre";
            this.rbsexohombre.UseVisualStyleBackColor = true;
            // 
            // rbsexomujer
            // 
            this.rbsexomujer.AutoSize = true;
            this.rbsexomujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsexomujer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbsexomujer.Location = new System.Drawing.Point(358, 52);
            this.rbsexomujer.Name = "rbsexomujer";
            this.rbsexomujer.Size = new System.Drawing.Size(81, 19);
            this.rbsexomujer.TabIndex = 17;
            this.rbsexomujer.TabStop = true;
            this.rbsexomujer.Text = "Femenino";
            this.rbsexomujer.UseVisualStyleBackColor = true;
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpais.Location = new System.Drawing.Point(284, 88);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(35, 16);
            this.lblpais.TabIndex = 18;
            this.lblpais.Text = "Pais";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblestado.Location = new System.Drawing.Point(286, 133);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(51, 16);
            this.lblestado.TabIndex = 20;
            this.lblestado.Text = "Estado";
            // 
            // comboBoxestado
            // 
            this.comboBoxestado.FormattingEnabled = true;
            this.comboBoxestado.Location = new System.Drawing.Point(284, 152);
            this.comboBoxestado.Name = "comboBoxestado";
            this.comboBoxestado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxestado.TabIndex = 21;
            // 
            // checkBoxterminos
            // 
            this.checkBoxterminos.AutoSize = true;
            this.checkBoxterminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxterminos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxterminos.Location = new System.Drawing.Point(292, 209);
            this.checkBoxterminos.Name = "checkBoxterminos";
            this.checkBoxterminos.Size = new System.Drawing.Size(148, 20);
            this.checkBoxterminos.TabIndex = 22;
            this.checkBoxterminos.Text = "Acepto los términos.";
            this.checkBoxterminos.UseVisualStyleBackColor = true;
            // 
            // buttonsave
            // 
            this.buttonsave.Location = new System.Drawing.Point(279, 236);
            this.buttonsave.Name = "buttonsave";
            this.buttonsave.Size = new System.Drawing.Size(75, 23);
            this.buttonsave.TabIndex = 23;
            this.buttonsave.Text = "Guardar";
            this.buttonsave.UseVisualStyleBackColor = true;
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(360, 236);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 24;
            this.buttonclear.Text = "Limpiar";
            this.buttonclear.UseVisualStyleBackColor = true;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(568, 446);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonsave);
            this.Controls.Add(this.checkBoxterminos);
            this.Controls.Add(this.comboBoxestado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.rbsexomujer);
            this.Controls.Add(this.rbsexohombre);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.textBoxpasswd2);
            this.Controls.Add(this.lblpasswd2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxpasswd);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.textBoxcorreo);
            this.Controls.Add(this.textBoxapellido);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.lblpasswd);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Name = "registro";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpasswd;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxapellido;
        private System.Windows.Forms.TextBox textBoxcorreo;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.TextBox textBoxpasswd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblpasswd2;
        private System.Windows.Forms.TextBox textBoxpasswd2;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.RadioButton rbsexohombre;
        private System.Windows.Forms.RadioButton rbsexomujer;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox comboBoxestado;
        private System.Windows.Forms.CheckBox checkBoxterminos;
        private System.Windows.Forms.Button buttonsave;
        private System.Windows.Forms.Button buttonclear;
    }
}