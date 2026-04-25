namespace TP_WinForm_Programacion3
{
    partial class MenuArticulos
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreArt = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblIDMarca = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbCargaDeDatos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.ListView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(138, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombreArt
            // 
            this.lblNombreArt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombreArt.AutoSize = true;
            this.lblNombreArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArt.Location = new System.Drawing.Point(59, 90);
            this.lblNombreArt.Name = "lblNombreArt";
            this.lblNombreArt.Size = new System.Drawing.Size(73, 20);
            this.lblNombreArt.TabIndex = 2;
            this.lblNombreArt.Text = "Nombre :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Location = new System.Drawing.Point(138, 118);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(167, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(65, 120);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 20);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblIDMarca
            // 
            this.lblIDMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIDMarca.AutoSize = true;
            this.lblIDMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDMarca.Location = new System.Drawing.Point(71, 150);
            this.lblIDMarca.Name = "lblIDMarca";
            this.lblIDMarca.Size = new System.Drawing.Size(61, 20);
            this.lblIDMarca.TabIndex = 6;
            this.lblIDMarca.Text = "Marca :";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCategoria.Location = new System.Drawing.Point(46, 182);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(86, 20);
            this.lblIDCategoria.TabIndex = 8;
            this.lblIDCategoria.Text = "Categoria :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrecio.Location = new System.Drawing.Point(138, 209);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(167, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(71, 211);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 20);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(28, 286);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(104, 20);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion : ";
            // 
            // btnAgregado
            // 
            this.btnAgregado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregado.Location = new System.Drawing.Point(233, 508);
            this.btnAgregado.Name = "btnAgregado";
            this.btnAgregado.Size = new System.Drawing.Size(99, 25);
            this.btnAgregado.TabIndex = 7;
            this.btnAgregado.Text = "Agregar ";
            this.btnAgregado.UseVisualStyleBackColor = true;
            this.btnAgregado.Click += new System.EventHandler(this.btnAgregado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(338, 508);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 25);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(138, 154);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(167, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(138, 181);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(167, 21);
            this.cboCategoria.TabIndex = 3;
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.Location = new System.Drawing.Point(138, 249);
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(167, 20);
            this.txtURLImagen.TabIndex = 5;
            this.txtURLImagen.Leave += new System.EventHandler(this.txtURLImagen_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Imagen(URL) :";
            // 
            // txtbCargaDeDatos
            // 
            this.txtbCargaDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCargaDeDatos.Location = new System.Drawing.Point(114, 12);
            this.txtbCargaDeDatos.Name = "txtbCargaDeDatos";
            this.txtbCargaDeDatos.Size = new System.Drawing.Size(227, 38);
            this.txtbCargaDeDatos.TabIndex = 21;
            this.txtbCargaDeDatos.Text = "Carga de datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDescripcion.HideSelection = false;
            this.txtDescripcion.Location = new System.Drawing.Point(32, 321);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(309, 142);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.UseCompatibleStateImageBehavior = false;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(311, 173);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(133, 96);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 22;
            this.pbxArticulo.TabStop = false;
            // 
            // MenuArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 545);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.txtbCargaDeDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURLImagen);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblIDMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreArt);
            this.Name = "MenuArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Articulos";
            this.Load += new System.EventHandler(this.MenuArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreArt;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblIDMarca;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAgregado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtURLImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbCargaDeDatos;
        private System.Windows.Forms.ListView txtDescripcion;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}