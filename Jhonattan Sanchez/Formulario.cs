using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jhonattan_Sanchez
{
    public partial class Formulario : Form
    {
        private CRUD formularioPrincipal;
        private int filaEditar = -1;
        private bool esEdicion = false;

        // Constructor para agregar nuevo registro
        public Formulario(CRUD formulario)
        {
            InitializeComponent();
            formularioPrincipal = formulario;
        }

        // Constructor para editar registro existente
        public Formulario(CRUD formulario, string codigo, string nombres, string apellidos, string telefono, string direccion, int fila)
        {
            InitializeComponent();
            formularioPrincipal = formulario;
            esEdicion = true;
            filaEditar = fila;

            // Llenar campos con los datos seleccionados
            txtcodigo.Text = codigo;
            txtnombres.Text = nombres;
            txtapellidos.Text = apellidos;
            txttel.Text = telefono;
            txtdir.Text = direccion;

            // Deshabilitar edición del campo código
            txtcodigo.Enabled = false;
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes poner validaciones o acciones al cambiar el texto
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Este método no tiene implementación
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            string nombres = txtnombres.Text;
            string apellidos = txtapellidos.Text;
            string telefono = txttel.Text;        // Asegúrate que el nombre del TextBox sea txttel
            string direccion = txtdir.Text;       // Asegúrate que el nombre del TextBox sea txtdir

            if (esEdicion && filaEditar != -1)
            {
                // Modo edición: actualizar fila existente
                formularioPrincipal.EditarFila(filaEditar, nombres, apellidos, telefono, direccion);
            }
            else
            {
                // Modo agregar: agregar nueva fila
                formularioPrincipal.AgregarFila(codigo, nombres, apellidos, telefono, direccion);
            }

            this.Close();

        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}