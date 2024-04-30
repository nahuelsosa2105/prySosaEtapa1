namespace prySosaEtapa1
{
    partial class frmMain
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
            this.pctFirma = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFirma
            // 
            this.pctFirma.BackColor = System.Drawing.Color.White;
            this.pctFirma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFirma.Location = new System.Drawing.Point(39, 35);
            this.pctFirma.Name = "pctFirma";
            this.pctFirma.Size = new System.Drawing.Size(390, 322);
            this.pctFirma.TabIndex = 0;
            this.pctFirma.TabStop = false;
            this.pctFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseDown);
            this.pctFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseMove);
            this.pctFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctFirma_MouseUp);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(487, 270);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(237, 87);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFirmar
            // 
            this.btnFirmar.BackColor = System.Drawing.Color.White;
            this.btnFirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirmar.Location = new System.Drawing.Point(487, 150);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(237, 87);
            this.btnFirmar.TabIndex = 2;
            this.btnFirmar.Text = "GUARDAR";
            this.btnFirmar.UseVisualStyleBackColor = false;
            this.btnFirmar.Click += new System.EventHandler(this.btnFirmar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(782, 404);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pctFirma);
            this.Name = "frmMain";
            this.Text = "Firma";
            ((System.ComponentModel.ISupportInitialize)(this.pctFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFirma;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnFirmar;
    }
}

