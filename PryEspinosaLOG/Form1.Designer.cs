namespace PryEspinosaLOG
{
    partial class mainform
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
            this.DataGridViewLOG = new System.Windows.Forms.DataGridView();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.btnConectarBase = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewLOG
            // 
            this.DataGridViewLOG.BackgroundColor = System.Drawing.Color.Ivory;
            this.DataGridViewLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLOG.Location = new System.Drawing.Point(48, 98);
            this.DataGridViewLOG.Name = "DataGridViewLOG";
            this.DataGridViewLOG.Size = new System.Drawing.Size(365, 194);
            this.DataGridViewLOG.TabIndex = 7;
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTraerDatos.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnTraerDatos.FlatAppearance.BorderSize = 2;
            this.btnTraerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraerDatos.Location = new System.Drawing.Point(251, 29);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(162, 37);
            this.btnTraerDatos.TabIndex = 5;
            this.btnTraerDatos.Text = "Traer Datos";
            this.btnTraerDatos.UseVisualStyleBackColor = false;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // btnConectarBase
            // 
            this.btnConectarBase.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConectarBase.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConectarBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectarBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarBase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConectarBase.Location = new System.Drawing.Point(65, 29);
            this.btnConectarBase.Name = "btnConectarBase";
            this.btnConectarBase.Size = new System.Drawing.Size(154, 37);
            this.btnConectarBase.TabIndex = 5;
            this.btnConectarBase.Text = "Conectar a la Base";
            this.btnConectarBase.UseVisualStyleBackColor = false;
            this.btnConectarBase.Click += new System.EventHandler(this.btnConectarBase_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(112, 17);
            this.lblEstadoConexion.Text = "Estado de Conexión";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(610, 381);
            this.Controls.Add(this.DataGridViewLOG);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.btnConectarBase);
            this.Controls.Add(this.statusStrip1);
            this.Name = "mainform";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLOG;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.Button btnConectarBase;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
    }
}

