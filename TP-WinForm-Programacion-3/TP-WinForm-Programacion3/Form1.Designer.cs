namespace TP_WinForm_Programacion3
{
    partial class FrmPrincipal
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
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.lblAccesos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(338, 75);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(100, 31);
            this.btnMarcas.TabIndex = 1;
            this.btnMarcas.Text = "MARCAS";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(465, 75);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(100, 31);
            this.btnCategoria.TabIndex = 2;
            this.btnCategoria.Text = "CATEGORIAS";
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(202, 75);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(100, 31);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "ARTICULOS";
            this.btnArticulos.UseVisualStyleBackColor = true;
            // 
            // lblAccesos
            // 
            this.lblAccesos.AutoSize = true;
            this.lblAccesos.Location = new System.Drawing.Point(111, 84);
            this.lblAccesos.Name = "lblAccesos";
            this.lblAccesos.Size = new System.Drawing.Size(57, 13);
            this.lblAccesos.TabIndex = 4;
            this.lblAccesos.Text = "Accesos : ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccesos);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.btnArticulos);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Label lblAccesos;
    }
}

