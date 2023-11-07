namespace WinFormsApp1
{
    partial class Mantenimiento
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
            label1 = new Label();
            label2 = new Label();
            lbCodigo = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCodNumero = new Label();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lvProductos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 84);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Precio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 56);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbCodigo.Location = new Point(28, 27);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(63, 20);
            lbCodigo.TabIndex = 2;
            lbCodigo.Text = "Codigo";
            lbCodigo.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(368, 84);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 242);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // lblCodNumero
            // 
            lblCodNumero.AutoSize = true;
            lblCodNumero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodNumero.Location = new Point(98, 27);
            lblCodNumero.Name = "lblCodNumero";
            lblCodNumero.Size = new Size(33, 20);
            lblCodNumero.TabIndex = 5;
            lblCodNumero.Text = "000";
            lblCodNumero.Click += label6_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(38, 145);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(93, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(201, 145);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(83, 23);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(368, 145);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lvProductos
            // 
            lvProductos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvProductos.GridLines = true;
            lvProductos.Location = new Point(28, 186);
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(666, 252);
            lvProductos.TabIndex = 9;
            lvProductos.UseCompatibleStateImageBehavior = false;
            lvProductos.View = View.Details;
            lvProductos.SelectedIndexChanged += listView1_SelectedIndexChanged;
            lvProductos.MouseDoubleClick += lvProductos_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "CODIGO";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "NOMBRE";
            columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRECIO";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "STOCK";
            columnHeader4.Width = 150;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(195, 23);
            txtNombre.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(98, 85);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(195, 23);
            txtPrecio.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(419, 85);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(195, 23);
            txtStock.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(254, 9);
            label7.Name = "label7";
            label7.Size = new Size(208, 28);
            label7.TabIndex = 13;
            label7.Text = "MANTENIMIENTO";
            // 
            // Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(726, 450);
            Controls.Add(label7);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCodNumero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Mantenimiento";
            Text = "Mantenimiento";
            Load += Mantenimiento_Load;
            MouseDoubleClick += Mantenimiento_MouseDoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbCodigo;
        private Label label4;
        private Label label5;
        private Label lblCodNumero;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView lvProductos;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox txtStock;
        private Label label7;
    }
}