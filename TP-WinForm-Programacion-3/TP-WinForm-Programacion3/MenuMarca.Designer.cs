namespace TP_WinForm_Programacion3
{
    partial class MenuMarca
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIDmarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(147, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIDmarca
            // 
            this.lblIDmarca.AutoSize = true;
            this.lblIDmarca.Location = new System.Drawing.Point(25, 42);
            this.lblIDmarca.Name = "lblIDmarca";
            this.lblIDmarca.Size = new System.Drawing.Size(58, 13);
            this.lblIDmarca.TabIndex = 2;
            this.lblIDmarca.Text = "Id Marca : ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(25, 84);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripcion :";
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(102, 39);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txbIdMarca.TabIndex = 4;
            this.txbIdMarca.Text = "0000";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(102, 84);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txbDescripcion.TabIndex = 5;
            // 
            // MenuMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 327);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbIdMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIDmarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.MaximumSize = new System.Drawing.Size(331, 366);
            this.MinimumSize = new System.Drawing.Size(331, 366);
            this.Name = "MenuMarca";
            this.Text = "Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIDmarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbIdMarca;
        private System.Windows.Forms.TextBox txbDescripcion;
    }
}