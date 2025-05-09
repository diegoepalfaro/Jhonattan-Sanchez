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
            label1.Location = new Point(89, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "BUSCAR";
            // 
            // Textbox
            // 
            Textbox.Location = new Point(164, 38);
            Textbox.Name = "Textbox";
            Textbox.Size = new Size(100, 23);
            Textbox.TabIndex = 1;
            // 
            // dtg1
            // 
            dtg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg1.Location = new Point(89, 112);
            dtg1.Name = "dtg1";
            dtg1.Size = new Size(448, 178);
            dtg1.TabIndex = 2;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(616, 55);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 3;
            btnagregar.Text = "AGREGAR";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(619, 99);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 4;
            btneditar.Text = "EDITAR";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(629, 152);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 23);
            btneliminar.TabIndex = 5;
            btneliminar.Text = "ELIMINAR";
            btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(629, 212);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 6;
            btnsalir.Text = "button1";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsalir);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnagregar);
            Controls.Add(dtg1);
            Controls.Add(Textbox);
            Controls.Add(label1);
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