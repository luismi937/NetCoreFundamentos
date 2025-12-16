namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            lblProducto = new Label();
            txtProductos = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            lblTienda = new Label();
            lstCosas = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            lblAmacen = new Label();
            lstAlmacen = new ListBox();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 23);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(68, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "PRODUCTO";
            // 
            // txtProductos
            // 
            txtProductos.Location = new Point(12, 46);
            txtProductos.Name = "txtProductos";
            txtProductos.Size = new Size(80, 23);
            txtProductos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 119);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(12, 177);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(153, 23);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(42, 15);
            lblTienda.TabIndex = 6;
            lblTienda.Text = "Tienda";
            // 
            // lstCosas
            // 
            lstCosas.FormattingEnabled = true;
            lstCosas.Location = new Point(153, 66);
            lstCosas.Name = "lstCosas";
            lstCosas.Size = new Size(120, 184);
            lstCosas.TabIndex = 7;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(279, 102);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 8;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(279, 148);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 9;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // lblAmacen
            // 
            lblAmacen.AutoSize = true;
            lblAmacen.Location = new Point(377, 23);
            lblAmacen.Name = "lblAmacen";
            lblAmacen.Size = new Size(54, 15);
            lblAmacen.TabIndex = 10;
            lblAmacen.Text = "Almacen";
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(377, 66);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(120, 184);
            lstAlmacen.TabIndex = 11;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(529, 102);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 12;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(529, 148);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 13;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 328);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(lblAmacen);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstCosas);
            Controls.Add(lblTienda);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProductos);
            Controls.Add(lblProducto);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProductos;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrar;
        private Label lblTienda;
        private ListBox lstCosas;
        private Button btnSeleccion;
        private Button btnTodos;
        private Label lblAmacen;
        private ListBox lstAlmacen;
        private Button btnSubir;
        private Button btnBajar;
    }
}