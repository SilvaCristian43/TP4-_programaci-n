namespace FrondEnd
{
    partial class inicio
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
            this.btcargar = new System.Windows.Forms.Button();
            this.btactualizar = new System.Windows.Forms.Button();
            this.btborrar = new System.Windows.Forms.Button();
            this.btmostrar = new System.Windows.Forms.Button();
            this.txtcargardni = new System.Windows.Forms.TextBox();
            this.txtcargarnombre = new System.Windows.Forms.TextBox();
            this.txtcargarequipo = new System.Windows.Forms.TextBox();
            this.txtcargarsuspencion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtactualizarsuspencion = new System.Windows.Forms.TextBox();
            this.txtactualizarequipo = new System.Windows.Forms.TextBox();
            this.txtactualizarnombre = new System.Windows.Forms.TextBox();
            this.txtactualizardni = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtborrardni = new System.Windows.Forms.TextBox();
            this.dgvprincipal = new System.Windows.Forms.DataGridView();
            this.btsalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbactualizartarjetas = new System.Windows.Forms.ComboBox();
            this.cmbcargartarjetas = new System.Windows.Forms.ComboBox();
            this.lbtexto = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(18, 340);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(100, 23);
            this.btcargar.TabIndex = 0;
            this.btcargar.Text = "CARGAR";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // btactualizar
            // 
            this.btactualizar.Location = new System.Drawing.Point(18, 430);
            this.btactualizar.Name = "btactualizar";
            this.btactualizar.Size = new System.Drawing.Size(100, 23);
            this.btactualizar.TabIndex = 2;
            this.btactualizar.Text = "ACTUALIZAR";
            this.btactualizar.UseVisualStyleBackColor = true;
            this.btactualizar.Click += new System.EventHandler(this.btactualizar_Click);
            // 
            // btborrar
            // 
            this.btborrar.Location = new System.Drawing.Point(18, 495);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(100, 23);
            this.btborrar.TabIndex = 4;
            this.btborrar.Text = "BORRAR";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click);
            // 
            // btmostrar
            // 
            this.btmostrar.Location = new System.Drawing.Point(18, 554);
            this.btmostrar.Name = "btmostrar";
            this.btmostrar.Size = new System.Drawing.Size(263, 23);
            this.btmostrar.TabIndex = 6;
            this.btmostrar.Text = "VER LISTA";
            this.btmostrar.UseVisualStyleBackColor = true;
            this.btmostrar.Click += new System.EventHandler(this.btmostrar_Click);
            // 
            // txtcargardni
            // 
            this.txtcargardni.Location = new System.Drawing.Point(181, 340);
            this.txtcargardni.Name = "txtcargardni";
            this.txtcargardni.Size = new System.Drawing.Size(100, 20);
            this.txtcargardni.TabIndex = 7;
            // 
            // txtcargarnombre
            // 
            this.txtcargarnombre.Location = new System.Drawing.Point(319, 340);
            this.txtcargarnombre.Name = "txtcargarnombre";
            this.txtcargarnombre.Size = new System.Drawing.Size(100, 20);
            this.txtcargarnombre.TabIndex = 9;
            // 
            // txtcargarequipo
            // 
            this.txtcargarequipo.Location = new System.Drawing.Point(449, 340);
            this.txtcargarequipo.Name = "txtcargarequipo";
            this.txtcargarequipo.Size = new System.Drawing.Size(100, 20);
            this.txtcargarequipo.TabIndex = 11;
            // 
            // txtcargarsuspencion
            // 
            this.txtcargarsuspencion.Location = new System.Drawing.Point(750, 340);
            this.txtcargarsuspencion.Name = "txtcargarsuspencion";
            this.txtcargarsuspencion.Size = new System.Drawing.Size(100, 20);
            this.txtcargarsuspencion.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "EQUIPO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "TARJETA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(747, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "DIAS DE SUSPENCION";
            // 
            // txtactualizarsuspencion
            // 
            this.txtactualizarsuspencion.Location = new System.Drawing.Point(750, 430);
            this.txtactualizarsuspencion.Name = "txtactualizarsuspencion";
            this.txtactualizarsuspencion.Size = new System.Drawing.Size(100, 20);
            this.txtactualizarsuspencion.TabIndex = 29;
            // 
            // txtactualizarequipo
            // 
            this.txtactualizarequipo.Location = new System.Drawing.Point(449, 430);
            this.txtactualizarequipo.Name = "txtactualizarequipo";
            this.txtactualizarequipo.Size = new System.Drawing.Size(100, 20);
            this.txtactualizarequipo.TabIndex = 27;
            // 
            // txtactualizarnombre
            // 
            this.txtactualizarnombre.Location = new System.Drawing.Point(319, 430);
            this.txtactualizarnombre.Name = "txtactualizarnombre";
            this.txtactualizarnombre.Size = new System.Drawing.Size(100, 20);
            this.txtactualizarnombre.TabIndex = 26;
            // 
            // txtactualizardni
            // 
            this.txtactualizardni.Location = new System.Drawing.Point(181, 430);
            this.txtactualizardni.Name = "txtactualizardni";
            this.txtactualizardni.Size = new System.Drawing.Size(100, 20);
            this.txtactualizardni.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "DNI";
            // 
            // txtborrardni
            // 
            this.txtborrardni.Location = new System.Drawing.Point(181, 498);
            this.txtborrardni.Name = "txtborrardni";
            this.txtborrardni.Size = new System.Drawing.Size(100, 20);
            this.txtborrardni.TabIndex = 35;
            // 
            // dgvprincipal
            // 
            this.dgvprincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprincipal.Location = new System.Drawing.Point(181, 3);
            this.dgvprincipal.Name = "dgvprincipal";
            this.dgvprincipal.ReadOnly = true;
            this.dgvprincipal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvprincipal.Size = new System.Drawing.Size(549, 282);
            this.dgvprincipal.TabIndex = 37;
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(750, 579);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(170, 23);
            this.btsalir.TabIndex = 38;
            this.btsalir.Text = "SALIR";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(747, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "DIAS DE SUSPENCION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "TARJETA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "EQUIPO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "NOMBRE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "DNI";
            // 
            // cmbactualizartarjetas
            // 
            this.cmbactualizartarjetas.FormattingEnabled = true;
            this.cmbactualizartarjetas.Items.AddRange(new object[] {
            "NINGUNA",
            "1 AMARILLA",
            "2 AMARILLA",
            "1 ROJA"});
            this.cmbactualizartarjetas.Location = new System.Drawing.Point(587, 429);
            this.cmbactualizartarjetas.Name = "cmbactualizartarjetas";
            this.cmbactualizartarjetas.Size = new System.Drawing.Size(121, 21);
            this.cmbactualizartarjetas.TabIndex = 44;
            this.cmbactualizartarjetas.SelectedIndexChanged += new System.EventHandler(this.cmbactualizartarjetas_SelectedIndexChanged);
            // 
            // cmbcargartarjetas
            // 
            this.cmbcargartarjetas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbcargartarjetas.FormattingEnabled = true;
            this.cmbcargartarjetas.Items.AddRange(new object[] {
            "NINGUNA",
            "1 AMARILLA",
            "2 AMARILLA",
            "1 ROJA"});
            this.cmbcargartarjetas.Location = new System.Drawing.Point(587, 342);
            this.cmbcargartarjetas.Name = "cmbcargartarjetas";
            this.cmbcargartarjetas.Size = new System.Drawing.Size(121, 21);
            this.cmbcargartarjetas.TabIndex = 45;
            this.cmbcargartarjetas.SelectedIndexChanged += new System.EventHandler(this.cmbcargartarjetas_SelectedIndexChanged);
            // 
            // lbtexto
            // 
            this.lbtexto.AutoSize = true;
            this.lbtexto.Location = new System.Drawing.Point(316, 564);
            this.lbtexto.Name = "lbtexto";
            this.lbtexto.Size = new System.Drawing.Size(0, 13);
            this.lbtexto.TabIndex = 46;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(645, 301);
            this.t1.Name = "t1";
            this.t1.ReadOnly = true;
            this.t1.Size = new System.Drawing.Size(14, 20);
            this.t1.TabIndex = 47;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(645, 388);
            this.t2.Name = "t2";
            this.t2.ReadOnly = true;
            this.t2.Size = new System.Drawing.Size(14, 20);
            this.t2.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrondEnd.Properties.Resources.Black_and_White_Photographic_Accounting_Service_Website__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(936, 566);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 612);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.lbtexto);
            this.Controls.Add(this.cmbcargartarjetas);
            this.Controls.Add(this.cmbactualizartarjetas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.dgvprincipal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtborrardni);
            this.Controls.Add(this.txtactualizarsuspencion);
            this.Controls.Add(this.txtactualizarequipo);
            this.Controls.Add(this.txtactualizarnombre);
            this.Controls.Add(this.txtactualizardni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcargarsuspencion);
            this.Controls.Add(this.txtcargarequipo);
            this.Controls.Add(this.txtcargarnombre);
            this.Controls.Add(this.txtcargardni);
            this.Controls.Add(this.btmostrar);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.btactualizar);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvprincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.Button btactualizar;
        private System.Windows.Forms.Button btborrar;
        private System.Windows.Forms.Button btmostrar;
        private System.Windows.Forms.TextBox txtcargardni;
        private System.Windows.Forms.TextBox txtcargarnombre;
        private System.Windows.Forms.TextBox txtcargarequipo;
        private System.Windows.Forms.TextBox txtcargarsuspencion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtactualizarsuspencion;
        private System.Windows.Forms.TextBox txtactualizarequipo;
        private System.Windows.Forms.TextBox txtactualizarnombre;
        private System.Windows.Forms.TextBox txtactualizardni;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtborrardni;
        private System.Windows.Forms.DataGridView dgvprincipal;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbactualizartarjetas;
        private System.Windows.Forms.ComboBox cmbcargartarjetas;
        private System.Windows.Forms.Label lbtexto;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

