namespace Caso03
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
            this.CobAnios = new System.Windows.Forms.ComboBox();
            this.CobMes = new System.Windows.Forms.ComboBox();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // CobAnios
            // 
            this.CobAnios.FormattingEnabled = true;
            this.CobAnios.Location = new System.Drawing.Point(13, 13);
            this.CobAnios.Name = "CobAnios";
            this.CobAnios.Size = new System.Drawing.Size(138, 21);
            this.CobAnios.TabIndex = 0;
            this.CobAnios.SelectionChangeCommitted += new System.EventHandler(this.CobAnios_SelectionChangeCommitted);
            // 
            // CobMes
            // 
            this.CobMes.FormattingEnabled = true;
            this.CobMes.Location = new System.Drawing.Point(217, 13);
            this.CobMes.Name = "CobMes";
            this.CobMes.Size = new System.Drawing.Size(138, 21);
            this.CobMes.TabIndex = 1;
            this.CobMes.SelectionChangeCommitted += new System.EventHandler(this.CobMes_SelectionChangeCommitted);
            // 
            // DgDatos
            // 
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Location = new System.Drawing.Point(13, 69);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.Size = new System.Drawing.Size(775, 369);
            this.DgDatos.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgDatos);
            this.Controls.Add(this.CobMes);
            this.Controls.Add(this.CobAnios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CobAnios;
        private System.Windows.Forms.ComboBox CobMes;
        private System.Windows.Forms.DataGridView DgDatos;
    }
}

