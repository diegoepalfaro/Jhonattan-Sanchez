namespace Jhonattan_Sanchez
{
    partial class Formulario
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
            Label label2;
            label1 = new Label();
            txtcodigo = new TextBox();
            txtnombres = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtapellidos = new TextBox();
            txttel = new TextBox();
            txtdir = new TextBox();
            btnguardar = new Button();
            btncancelar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 123);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(170, 142);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(100, 23);
            txtcodigo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 183);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombres";
            // 
            // txtnombres
            // 
            txtnombres.Location = new Point(172, 208);
            txtnombres.Name = "txtnombres";
            txtnombres.Size = new Size(100, 23);
            txtnombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 247);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 308);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 366);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 6;
            label5.Text = "Direccion";
            // 
            // txtapellidos
            // 
            txtapellidos.Location = new Point(177, 275);
            txtapellidos.Name = "txtapellidos";
            txtapellidos.Size = new Size(100, 23);
            txtapellidos.TabIndex = 7;
            // 
            // txttel
            // 
            txttel.Location = new Point(181, 336);
            txttel.Name = "txttel";
            txttel.Size = new Size(100, 23);
            txttel.TabIndex = 8;
            // 
            // txtdir
            // 
            txtdir.Location = new Point(179, 399);
            txtdir.Name = "txtdir";
            txtdir.Size = new Size(100, 23);
            txtdir.TabIndex = 9;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(181, 452);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 10;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(181, 493);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 11;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 580);
            Controls.Add(btncancelar);
            Controls.Add(btnguardar);
            Controls.Add(txtdir);
            Controls.Add(txttel);
            Controls.Add(txtapellidos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtnombres);
            Controls.Add(label2);
            Controls.Add(txtcodigo);
            Controls.Add(label1);
            Name = "Formulario";
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtcodigo;
        private Label label2;
        private TextBox txtnombres;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtapellidos;
        private TextBox txttel;
        private TextBox txtdir;
        private Button btnguardar;
        private Button btncancelar;
    }
}