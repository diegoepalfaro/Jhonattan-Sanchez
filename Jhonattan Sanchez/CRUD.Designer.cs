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
            dtg1.Location = new Point(102, 149);
            dtg1.Margin = new Padding(3, 4, 3, 4);
            dtg1.Name = "dtg1";
            dtg1.RowHeadersWidth = 51;
            dtg1.Size = new Size(512, 237);
            dtg1.TabIndex = 2;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(704, 73);
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
            btneditar.Location = new Point(707, 132);
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
            btneliminar.Location = new Point(719, 203);
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
            btnsalir.Location = new Point(719, 283);
            btnsalir.Margin = new Padding(3, 4, 3, 4);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(86, 31);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "button1";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
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
    }
}