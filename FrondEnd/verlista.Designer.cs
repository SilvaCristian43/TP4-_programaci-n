namespace FrondEnd
{
    partial class verlista
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
            this.dgvver = new System.Windows.Forms.DataGridView();
            this.btsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvver
            // 
            this.dgvver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvver.Location = new System.Drawing.Point(12, 12);
            this.dgvver.Name = "dgvver";
            this.dgvver.ReadOnly = true;
            this.dgvver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvver.Size = new System.Drawing.Size(549, 466);
            this.dgvver.TabIndex = 38;
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(391, 501);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(170, 23);
            this.btsalir.TabIndex = 39;
            this.btsalir.Text = "SALIR";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // verlista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 536);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.dgvver);
            this.Name = "verlista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verlista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvver;
        private System.Windows.Forms.Button btsalir;
    }
}