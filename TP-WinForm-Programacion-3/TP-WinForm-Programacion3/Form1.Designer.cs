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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAgregando = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLista_Articulos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tlAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Codigo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Lista De Articulos";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Categoria";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Marca";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nombre";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAgregando
            // 
            this.btnAgregando.Location = new System.Drawing.Point(12, 75);
            this.btnAgregando.Name = "btnAgregando";
            this.btnAgregando.Size = new System.Drawing.Size(75, 23);
            this.btnAgregando.TabIndex = 5;
            this.btnAgregando.Text = "Agregar";
            this.btnAgregando.UseVisualStyleBackColor = true;
            this.btnAgregando.Click += new System.EventHandler(this.btnAgregando_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(93, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Modificar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(174, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(255, 76);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 8;
            this.btnDetalles.Text = "Ver Detalle";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(333, 60);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(81, 13);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar Articulo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(451, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // lblLista_Articulos
            // 
            this.lblLista_Articulos.AutoSize = true;
            this.lblLista_Articulos.Location = new System.Drawing.Point(12, 102);
            this.lblLista_Articulos.Name = "lblLista_Articulos";
            this.lblLista_Articulos.Size = new System.Drawing.Size(89, 13);
            this.lblLista_Articulos.TabIndex = 20;
            this.lblLista_Articulos.Text = "Lista De Articulos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "-------------";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(336, 76);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "Buscar";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 131);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(524, 304);
            this.dgvArticulos.TabIndex = 23;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(545, 131);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(178, 246);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 24;
            this.pbxArticulo.TabStop = false;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGestion,
            this.tsmAyuda});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(735, 24);
            this.msPrincipal.TabIndex = 25;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsGestion
            // 
            this.tsGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMarca,
            this.tsCategoria,
            this.tsSalir});
            this.tsGestion.Name = "tsGestion";
            this.tsGestion.Size = new System.Drawing.Size(59, 20);
            this.tsGestion.Text = "Gestion";
            // 
            // tsMarca
            // 
            this.tsMarca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlAgregarMarca,
            this.tsEditarMarca,
            this.tsEliminarMarca});
            this.tsMarca.Name = "tsMarca";
            this.tsMarca.Size = new System.Drawing.Size(125, 22);
            this.tsMarca.Text = "Marca";
            // 
            // tlAgregarMarca
            // 
            this.tlAgregarMarca.Name = "tlAgregarMarca";
            this.tlAgregarMarca.Size = new System.Drawing.Size(117, 22);
            this.tlAgregarMarca.Text = "Agregar";
            this.tlAgregarMarca.Click += new System.EventHandler(this.tlAgregarMarca_Click);
            // 
            // tsEditarMarca
            // 
            this.tsEditarMarca.Name = "tsEditarMarca";
            this.tsEditarMarca.Size = new System.Drawing.Size(117, 22);
            this.tsEditarMarca.Text = "Editar";
            // 
            // tsEliminarMarca
            // 
            this.tsEliminarMarca.Name = "tsEliminarMarca";
            this.tsEliminarMarca.Size = new System.Drawing.Size(117, 22);
            this.tsEliminarMarca.Text = "Eliminar";
            // 
            // tsCategoria
            // 
            this.tsCategoria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregarCategoria,
            this.tsEditarCategoria,
            this.tsEliminarCategoria});
            this.tsCategoria.Name = "tsCategoria";
            this.tsCategoria.Size = new System.Drawing.Size(125, 22);
            this.tsCategoria.Text = "Categoria";
            // 
            // tsAgregarCategoria
            // 
            this.tsAgregarCategoria.Name = "tsAgregarCategoria";
            this.tsAgregarCategoria.Size = new System.Drawing.Size(117, 22);
            this.tsAgregarCategoria.Text = "Agregar";
            // 
            // tsEditarCategoria
            // 
            this.tsEditarCategoria.Name = "tsEditarCategoria";
            this.tsEditarCategoria.Size = new System.Drawing.Size(117, 22);
            this.tsEditarCategoria.Text = "Editar";
            // 
            // tsEliminarCategoria
            // 
            this.tsEliminarCategoria.Name = "tsEliminarCategoria";
            this.tsEliminarCategoria.Size = new System.Drawing.Size(117, 22);
            this.tsEliminarCategoria.Text = "Eliminar";
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(125, 22);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Location = new System.Drawing.Point(417, 79);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(122, 20);
            this.txbBusqueda.TabIndex = 26;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(548, 77);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 27;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(545, 60);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(38, 13);
            this.lblFiltro.TabIndex = 28;
            this.lblFiltro.Text = "Filtrar :";
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(735, 447);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txbBusqueda);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLista_Articulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnAgregando);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button Detalle;
        private System.Windows.Forms.Button Agregar1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAgregando;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLista_Articulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsGestion;
        private System.Windows.Forms.ToolStripMenuItem tsMarca;
        private System.Windows.Forms.ToolStripMenuItem tlAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsEditarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsEliminarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsAgregarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsEditarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsEliminarCategoria;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
    }
}

