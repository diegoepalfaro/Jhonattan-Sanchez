namespace Jhonattan_Sanchez
{
    partial class CRUD
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
            Textbox = new TextBox();
            dtg1 = new DataGridView();
            btnagregar = new Button();
            btneditar = new Button();
            btneliminar = new Button();
            btnsalir = new Button();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtg1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "BUSCAR";
            // 
            // Textbox
            // 
            Textbox.Location = new Point(187, 51);
            Textbox.Margin = new Padding(3, 4, 3, 4);
            Textbox.Name = "Textbox";
            Textbox.Size = new Size(114, 27);
            Textbox.TabIndex = 1;
            Textbox.TextChanged += Textbox_TextChanged;
            // 
            // dtg1
            // 
            dtg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Apellido, Telefono, Direccion });
            dtg1.Location = new Point(26, 149);
            dtg1.Margin = new Padding(3, 4, 3, 4);
            dtg1.Name = "dtg1";
            dtg1.RowHeadersWidth = 51;
            dtg1.Size = new Size(687, 237);
            dtg1.TabIndex = 2;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(752, 73);
            btnagregar.Margin = new Padding(3, 4, 3, 4);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(86, 31);
            btnagregar.TabIndex = 3;
            btnagregar.Text = "AGREGAR";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(752, 127);
            btneditar.Margin = new Padding(3, 4, 3, 4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(86, 31);
            btneditar.TabIndex = 4;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(752, 196);
            btneliminar.Margin = new Padding(3, 4, 3, 4);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(86, 31);
            btneliminar.TabIndex = 5;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(752, 283);
            btnsalir.Margin = new Padding(3, 4, 3, 4);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(86, 31);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "CERRAR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnsalir);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnagregar);
            Controls.Add(dtg1);
            Controls.Add(Textbox);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUD";
            Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)dtg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Textbox;
        private DataGridView dtg1;
        private Button btnagregar;
        private Button btneditar;
        private Button btneliminar;
        private Button btnsalir;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
    }
}