namespace login_regis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.txrcontraseña = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnregistrate = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(94, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "registrate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "no tienes cuenta";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Location = new System.Drawing.Point(23, 279);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(216, 35);
            this.btnentrar.TabIndex = 30;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txrcontraseña
            // 
            this.txrcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txrcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txrcontraseña.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrcontraseña.Location = new System.Drawing.Point(23, 198);
            this.txrcontraseña.Multiline = true;
            this.txrcontraseña.Name = "txrcontraseña";
            this.txrcontraseña.Size = new System.Drawing.Size(216, 28);
            this.txrcontraseña.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(23, 128);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(216, 28);
            this.txtusuario.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "usuario";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Location = new System.Drawing.Point(33, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 27);
            this.label14.TabIndex = 24;
            this.label14.Text = "INICIAR";
            // 
            // btnregistrate
            // 
            this.btnregistrate.BackColor = System.Drawing.Color.White;
            this.btnregistrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrate.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnregistrate.Location = new System.Drawing.Point(23, 329);
            this.btnregistrate.Name = "btnregistrate";
            this.btnregistrate.Size = new System.Drawing.Size(216, 35);
            this.btnregistrate.TabIndex = 34;
            this.btnregistrate.Text = "REGISTRATE";
            this.btnregistrate.UseVisualStyleBackColor = false;
            this.btnregistrate.Click += new System.EventHandler(this.btnregistrate_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnsalir.Location = new System.Drawing.Point(217, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(47, 22);
            this.btnsalir.TabIndex = 35;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(266, 431);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txrcontraseña);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.TextBox txrcontraseña;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnregistrate;
        private System.Windows.Forms.Button btnsalir;
    }
}

