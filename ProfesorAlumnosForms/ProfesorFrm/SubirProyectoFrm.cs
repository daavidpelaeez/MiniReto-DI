using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfesorFrm
{
    public partial class SubirProyectoFrm : Form
    {
        public SubirProyectoFrm()
        {
            InitializeComponent();
        }

        private void ConfigurarComboBox(ComboBox comboBox, List<KeyValuePair<string, string>> items)
        {
            comboBox.Items.Clear(); // Limpiar cualquier ítem previo
            comboBox.DisplayMember = "Key"; // Lo que el usuario verá en el ComboBox
            comboBox.ValueMember = "Value"; // El valor asociado a cada ítem
            foreach (var item in items)
            {
                comboBox.Items.Add(item); // Agregar cada ítem a la lista del ComboBox
            }
        }

        private void configurarComboBox()
        {
            // Configurar ComboBox Tipo
            ConfigurarComboBox(cbTipo, new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Tipo 1", "1"),
                new KeyValuePair<string, string>("Tipo 2", "2"),
                new KeyValuePair<string, string>("Tipo 3", "3")
            });

            // Configurar ComboBox Tutor
            ConfigurarComboBox(cbTutor, new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Tutor A", "A"),
                new KeyValuePair<string, string>("Tutor B", "B"),
                new KeyValuePair<string, string>("Tutor C", "C")
            });

            // Configurar ComboBox Ciclo
            ConfigurarComboBox(cbCiclo, new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("Ciclo 1", "A"),
                new KeyValuePair<string, string>("Ciclo 2", "B"),
                new KeyValuePair<string, string>("Ciclo 3", "C")
            });
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = null;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Estás seguro de que deseas cancelar la creación del profesor? Los cambios no guardados se perderán.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialog == DialogResult.OK)
            {
                this.Close();
            }

            if (dialog == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar un archivo de logo";

               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    MessageBox.Show("Logo seleccionado correctamente.", "Subir Logo");
                }
            }
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {

        }

        private void btnProyecto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                
                openFileDialog.Filter = "Archivos de proyecto (*.zip;*.xml)|*.zip;*.xml|Todos los archivos (*.*)|*.*";
                openFileDialog.Title = "Seleccionar un archivo de proyecto";

               
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    MessageBox.Show("Archivo seleccionado correctamente.", "Subir Proyecto");
                }
            }
        }
    }
}
