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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        public void AgregarFila(string codigo, string nombres, string apellidos, string telefono, string direccion)
        {
            dtg1.Rows.Add(codigo, nombres, apellidos, telefono, direccion);
            // Autoajustar el tamaño de las columnas al contenido
            dtg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void EditarFila(int fila, string nombres, string apellidos, string telefono, string direccion)
        {
            dtg1.Rows[fila].Cells[1].Value = nombres;
            dtg1.Rows[fila].Cells[2].Value = apellidos;
            dtg1.Rows[fila].Cells[3].Value = telefono;
            dtg1.Rows[fila].Cells[4].Value = direccion;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Formulario nuevoFormulario = new Formulario(this); // pasar referencia
            nuevoFormulario.ShowDialog();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            dtg1.ColumnCount = 5;
            dtg1.Columns[0].Name = "Código";
            dtg1.Columns[1].Name = "Nombres";
            dtg1.Columns[2].Name = "Apellidos";
            dtg1.Columns[3].Name = "Teléfono";
            dtg1.Columns[4].Name = "Dirección";
            dtg1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtg1.CurrentRow != null)
            {
                int filaSeleccionada = dtg1.CurrentRow.Index;
                string codigo = dtg1.Rows[filaSeleccionada].Cells[0].Value.ToString();
                string nombres = dtg1.Rows[filaSeleccionada].Cells[1].Value.ToString();
                string apellidos = dtg1.Rows[filaSeleccionada].Cells[2].Value.ToString();
                string telefono = dtg1.Rows[filaSeleccionada].Cells[3].Value.ToString();
                string direccion = dtg1.Rows[filaSeleccionada].Cells[4].Value.ToString();
                Formulario editarForm = new Formulario(this, codigo, nombres, apellidos, telefono, direccion, filaSeleccionada);
                editarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para editar.", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay filas en el DataGridView
            if (dtg1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registros para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Verificar si hay una fila seleccionada
            if (dtg1.CurrentRow == null || dtg1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Debe haber registros ingresados.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Confirmar con el usuario
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
            "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                dtg1.Rows.RemoveAt(dtg1.CurrentRow.Index);
            }

           
        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = Textbox.Text.ToLower();
            foreach (DataGridViewRow fila in dtg1.Rows)
            {
                // Evitar error al verificar filas nuevas vacías
                if (fila.IsNewRow) continue;
                bool visible = false;
                // Recorremos todas las celdas de la fila
                foreach (DataGridViewCell celda in fila.Cells)
                {
                    if (celda.Value != null && celda.Value.ToString().ToLower().Contains(textoBusqueda))
                    {
                        visible = true;
                        break;
                    }
                }
                fila.Visible = visible;
            }
            // Si no hay ninguna fila visible
            bool hayResultados = false;
            foreach (DataGridViewRow fila in dtg1.Rows)
            {
                if (fila.Visible && !fila.IsNewRow)
                {
                    hayResultados = true;
                    break;
                }
            }
            if (!hayResultados)
            {
                // Opcional: mostrar mensaje o dejar el grid vacío
                // MessageBox.Show("No se encontraron resultados.");
            }
        }
    }
}
