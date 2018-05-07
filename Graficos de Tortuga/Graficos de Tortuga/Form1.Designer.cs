namespace Graficos_de_Tortuga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.flechaArriba = new System.Windows.Forms.Button();
            this.flechaAbajo = new System.Windows.Forms.Button();
            this.flechaIzquierda = new System.Windows.Forms.Button();
            this.flechaDerecha = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lblavanzar = new System.Windows.Forms.Label();
            this.GrPluma = new System.Windows.Forms.GroupBox();
            this.radioButtonAbajo = new System.Windows.Forms.RadioButton();
            this.radioButtonArriba = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnAvanzarDatos = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GrPluma.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(72, 98);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(631, 641);
            this.textBox1.TabIndex = 0;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(782, 283);
            this.btnAvanzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(112, 35);
            this.btnAvanzar.TabIndex = 1;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(812, 242);
            this.lblPosicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(53, 20);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Text = "label1";
            // 
            // flechaArriba
            // 
            this.flechaArriba.Image = ((System.Drawing.Image)(resources.GetObject("flechaArriba.Image")));
            this.flechaArriba.Location = new System.Drawing.Point(974, 61);
            this.flechaArriba.Name = "flechaArriba";
            this.flechaArriba.Size = new System.Drawing.Size(100, 100);
            this.flechaArriba.TabIndex = 7;
            this.flechaArriba.Text = "0";
            this.flechaArriba.UseVisualStyleBackColor = true;
            this.flechaArriba.Click += new System.EventHandler(this.Girar_Click);
            // 
            // flechaAbajo
            // 
            this.flechaAbajo.Image = ((System.Drawing.Image)(resources.GetObject("flechaAbajo.Image")));
            this.flechaAbajo.Location = new System.Drawing.Point(974, 172);
            this.flechaAbajo.Name = "flechaAbajo";
            this.flechaAbajo.Size = new System.Drawing.Size(100, 100);
            this.flechaAbajo.TabIndex = 8;
            this.flechaAbajo.Text = "2";
            this.flechaAbajo.UseVisualStyleBackColor = true;
            this.flechaAbajo.Click += new System.EventHandler(this.Girar_Click);
            // 
            // flechaIzquierda
            // 
            this.flechaIzquierda.Image = ((System.Drawing.Image)(resources.GetObject("flechaIzquierda.Image")));
            this.flechaIzquierda.Location = new System.Drawing.Point(868, 115);
            this.flechaIzquierda.Name = "flechaIzquierda";
            this.flechaIzquierda.Size = new System.Drawing.Size(100, 100);
            this.flechaIzquierda.TabIndex = 9;
            this.flechaIzquierda.Text = "3";
            this.flechaIzquierda.UseVisualStyleBackColor = true;
            this.flechaIzquierda.Click += new System.EventHandler(this.Girar_Click);
            // 
            // flechaDerecha
            // 
            this.flechaDerecha.Image = ((System.Drawing.Image)(resources.GetObject("flechaDerecha.Image")));
            this.flechaDerecha.Location = new System.Drawing.Point(1080, 115);
            this.flechaDerecha.Name = "flechaDerecha";
            this.flechaDerecha.Size = new System.Drawing.Size(100, 100);
            this.flechaDerecha.TabIndex = 10;
            this.flechaDerecha.Text = "1";
            this.flechaDerecha.UseVisualStyleBackColor = true;
            this.flechaDerecha.Click += new System.EventHandler(this.Girar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(987, 23);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 20);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Derecha";
            // 
            // txtPasos
            // 
            this.txtPasos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtPasos.Location = new System.Drawing.Point(974, 287);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(100, 29);
            this.txtPasos.TabIndex = 12;
            // 
            // lblavanzar
            // 
            this.lblavanzar.AutoSize = true;
            this.lblavanzar.Location = new System.Drawing.Point(902, 290);
            this.lblavanzar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblavanzar.Name = "lblavanzar";
            this.lblavanzar.Size = new System.Drawing.Size(56, 20);
            this.lblavanzar.TabIndex = 13;
            this.lblavanzar.Text = "Pasos";
            // 
            // GrPluma
            // 
            this.GrPluma.Controls.Add(this.radioButtonAbajo);
            this.GrPluma.Controls.Add(this.radioButtonArriba);
            this.GrPluma.Location = new System.Drawing.Point(1069, 336);
            this.GrPluma.Name = "GrPluma";
            this.GrPluma.Size = new System.Drawing.Size(200, 91);
            this.GrPluma.TabIndex = 14;
            this.GrPluma.TabStop = false;
            this.GrPluma.Text = "Pluma";
            // 
            // radioButtonAbajo
            // 
            this.radioButtonAbajo.AutoSize = true;
            this.radioButtonAbajo.Location = new System.Drawing.Point(122, 41);
            this.radioButtonAbajo.Name = "radioButtonAbajo";
            this.radioButtonAbajo.Size = new System.Drawing.Size(69, 24);
            this.radioButtonAbajo.TabIndex = 1;
            this.radioButtonAbajo.TabStop = true;
            this.radioButtonAbajo.Text = "Abajo";
            this.radioButtonAbajo.UseVisualStyleBackColor = true;
            // 
            // radioButtonArriba
            // 
            this.radioButtonArriba.AutoSize = true;
            this.radioButtonArriba.Location = new System.Drawing.Point(6, 41);
            this.radioButtonArriba.Name = "radioButtonArriba";
            this.radioButtonArriba.Size = new System.Drawing.Size(72, 24);
            this.radioButtonArriba.TabIndex = 0;
            this.radioButtonArriba.TabStop = true;
            this.radioButtonArriba.Text = "Arriba";
            this.radioButtonArriba.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 478);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Datos";
            // 
            // txtDatos
            // 
            this.txtDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtDatos.Location = new System.Drawing.Point(974, 475);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(173, 29);
            this.txtDatos.TabIndex = 15;
            // 
            // btnAvanzarDatos
            // 
            this.btnAvanzarDatos.Location = new System.Drawing.Point(991, 512);
            this.btnAvanzarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvanzarDatos.Name = "btnAvanzarDatos";
            this.btnAvanzarDatos.Size = new System.Drawing.Size(112, 35);
            this.btnAvanzarDatos.TabIndex = 17;
            this.btnAvanzarDatos.Text = "Avanzar";
            this.btnAvanzarDatos.UseVisualStyleBackColor = true;
            this.btnAvanzarDatos.Click += new System.EventHandler(this.btnAvanzarDatos_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(731, 636);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(112, 35);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "7 Fin de datos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(736, 552);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "6 Imprime el tablero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "2 Pluma abajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(736, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "3 Gira derecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(737, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "4 Gira izquierda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 532);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "5: avance  Avanza x espacios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "1 Pluma arriba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAvanzarDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.GrPluma);
            this.Controls.Add(this.lblavanzar);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.flechaDerecha);
            this.Controls.Add(this.flechaIzquierda);
            this.Controls.Add(this.flechaAbajo);
            this.Controls.Add(this.flechaArriba);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrPluma.ResumeLayout(false);
            this.GrPluma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Button flechaArriba;
        private System.Windows.Forms.Button flechaAbajo;
        private System.Windows.Forms.Button flechaIzquierda;
        private System.Windows.Forms.Button flechaDerecha;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label lblavanzar;
        private System.Windows.Forms.GroupBox GrPluma;
        private System.Windows.Forms.RadioButton radioButtonAbajo;
        private System.Windows.Forms.RadioButton radioButtonArriba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnAvanzarDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

