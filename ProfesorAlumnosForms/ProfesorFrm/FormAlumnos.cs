namespace AlumnosFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            configurarComboBox();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void configurarComboBox()
        {
            cbGenero.Items.Add(new KeyValuePair<string, string>("Masculino", "M"));
            cbGenero.Items.Add(new KeyValuePair<string, string>("Femenino", "F"));
            cbGenero.Items.Add(new KeyValuePair<string, string>("Otros", "NB"));

            cbGenero.DisplayMember = "Key"; // Lo que ve el usuario
            cbGenero.ValueMember = "Value"; // El valor asociado al ítem
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
                if(control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = null;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           DialogResult dialog = MessageBox.Show("¿Estás seguro de que deseas cancelar la creación del alumno? Los cambios no guardados se perderán.", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(dialog == DialogResult.OK)
            {
                this.Close();
            }

            if (dialog == DialogResult.Cancel)
            {
                return;
            }

        }
    }
}
