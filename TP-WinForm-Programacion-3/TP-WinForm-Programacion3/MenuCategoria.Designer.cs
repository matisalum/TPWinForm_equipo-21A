namespace TP_WinForm_Programacion3
{
    partial class MenuCategoria
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
            this.txtDescripcion = new System.Windows.Forms.ListView();
            this.txbIdMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIDCargoria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.HideSelection = false;
            this.txtDescripcion.Location = new System.Drawing.Point(88, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(197, 78);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.UseCompatibleStateImageBehavior = false;
            // 
            // txbIdMarca
            // 
            this.txbIdMarca.Location = new System.Drawing.Point(88, 28);
            this.txbIdMarca.Name = "txbIdMarca";
            this.txbIdMarca.Size = new System.Drawing.Size(100, 20);
            this.txbIdMarca.TabIndex = 17;
            this.txbIdMarca.Text = "0000";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 73);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion :";
            // 
            // lblIDCargoria
            // 
            this.lblIDCargoria.AutoSize = true;
            this.lblIDCargoria.Location = new System.Drawing.Point(11, 31);
            this.lblIDCargoria.Name = "lblIDCargoria";
            this.lblIDCargoria.Size = new System.Drawing.Size(73, 13);
            this.lblIDCargoria.TabIndex = 15;
            this.lblIDCargoria.Text = "Id Categoria : ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(147, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // MenuCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 327);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txbIdMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblIDCargoria);
            this.MaximumSize = new System.Drawing.Size(331, 366);
            this.MinimumSize = new System.Drawing.Size(331, 366);
            this.Name = "MenuCategoria";
            this.Text = "MenuCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView txtDescripcion;
        private System.Windows.Forms.TextBox txbIdMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIDCargoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}