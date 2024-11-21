namespace AlumnosFrm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblDni = new Label();
            lblCorreo = new Label();
            lblPass = new Label();
            lblTelefono = new Label();
            lblGenero = new Label();
            lblFechaNac = new Label();
            lblCicloActual = new Label();
            label1 = new Label();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtCicloActual = new TextBox();
            txtCorreo = new TextBox();
            cbGenero = new ComboBox();
            txtPass = new TextBox();
            dtpFechaNac = new DateTimePicker();
            cbActivo = new CheckBox();
            txtDni = new TextBox();
            btnCrear = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(347, 151);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(655, 308);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(347, 232);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo electrónico";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(41, 308);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 5;
            lblPass.Text = "Contraseña";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(655, 151);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Teléfono";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(655, 232);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(45, 15);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Género";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(347, 308);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(117, 15);
            lblFechaNac.TabIndex = 8;
            lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblCicloActual
            // 
            lblCicloActual.AutoSize = true;
            lblCicloActual.Location = new Point(39, 232);
            lblCicloActual.Name = "lblCicloActual";
            lblCicloActual.Size = new Size(69, 15);
            lblCicloActual.TabIndex = 10;
            lblCicloActual.Text = "Ciclo actual";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 58);
            label1.Name = "label1";
            label1.Size = new Size(317, 50);
            label1.TabIndex = 11;
            label1.Text = "Perfil de Alumno";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(347, 169);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(252, 23);
            txtApellidos.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(655, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 23);
            txtTelefono.TabIndex = 13;
            // 
            // txtCicloActual
            // 
            txtCicloActual.Location = new Point(41, 250);
            txtCicloActual.Name = "txtCicloActual";
            txtCicloActual.Size = new Size(252, 23);
            txtCicloActual.TabIndex = 14;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(347, 250);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(252, 23);
            txtCorreo.TabIndex = 15;
            // 
            // cbGenero
            // 
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(655, 250);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(252, 23);
            cbGenero.TabIndex = 16;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(41, 326);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(252, 23);
            txtPass.TabIndex = 17;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(347, 326);
            dtpFechaNac.MaxDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            dtpFechaNac.MinDate = new DateTime(1904, 6, 11, 0, 0, 0, 0);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(252, 23);
            dtpFechaNac.TabIndex = 18;
            dtpFechaNac.Value = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.Location = new Point(233, 225);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(60, 19);
            cbActivo.TabIndex = 19;
            cbActivo.Text = "Activo";
            cbActivo.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(655, 326);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(252, 23);
            txtDni.TabIndex = 20;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(280, 399);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(100, 38);
            btnCrear.TabIndex = 21;
            btnCrear.Text = "Aceptar";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(417, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 38);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(552, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 38);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 466);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(txtDni);
            Controls.Add(cbActivo);
            Controls.Add(dtpFechaNac);
            Controls.Add(txtPass);
            Controls.Add(cbGenero);
            Controls.Add(txtCorreo);
            Controls.Add(txtCicloActual);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(label1);
            Controls.Add(lblCicloActual);
            Controls.Add(lblFechaNac);
            Controls.Add(lblGenero);
            Controls.Add(lblTelefono);
            Controls.Add(lblPass);
            Controls.Add(lblCorreo);
            Controls.Add(lblDni);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Crear Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblDni;
        private Label lblCorreo;
        private Label lblPass;
        private Label lblTelefono;
        private Label lblGenero;
        private Label lblFechaNac;
        private Label lblCicloActual;
        private Label label1;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtCicloActual;
        private TextBox txtCorreo;
        private ComboBox cbGenero;
        private TextBox txtPass;
        private DateTimePicker dtpFechaNac;
        private CheckBox cbActivo;
        private TextBox txtDni;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnCancelar;
    }
}
