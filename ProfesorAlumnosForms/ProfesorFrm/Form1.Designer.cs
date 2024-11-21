namespace ProfesorFrm
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
            txtApellidos = new TextBox();
            textBox3 = new TextBox();
            txtPass = new TextBox();
            txtTelefono = new TextBox();
            label1 = new Label();
            lblEspecialidad = new Label();
            lblNombre = new Label();
            label4 = new Label();
            lblTelefono = new Label();
            lblApellidos = new Label();
            label7 = new Label();
            dtpFechaNac = new Label();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cbGenero = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 169);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(252, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(347, 169);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(252, 23);
            txtApellidos.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(252, 23);
            textBox3.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(41, 326);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(252, 23);
            txtPass.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(655, 169);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(252, 23);
            txtTelefono.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 58);
            label1.Name = "label1";
            label1.Size = new Size(327, 50);
            label1.TabIndex = 5;
            label1.Text = "Perfil de Profesor";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(41, 232);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(72, 15);
            lblEspecialidad.TabIndex = 6;
            lblEspecialidad.Text = "Especialidad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 232);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Género";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(655, 151);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(347, 151);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(56, 15);
            lblApellidos.TabIndex = 10;
            lblApellidos.Text = "Apellidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 232);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 11;
            label7.Text = "Correo electrónico";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.AutoSize = true;
            dtpFechaNac.Location = new Point(347, 308);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(117, 15);
            dtpFechaNac.TabIndex = 12;
            dtpFechaNac.Text = "Fecha de nacimiento";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(347, 250);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(252, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(655, 326);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(252, 23);
            textBox9.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(655, 308);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 17;
            label9.Text = "DNI";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 308);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 18;
            label10.Text = "Contraseña";
            // 
            // cbGenero
            // 
            cbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(655, 250);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(252, 23);
            cbGenero.TabIndex = 19;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(280, 399);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 38);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(552, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 38);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(347, 326);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(233, 225);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(537, 225);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "Admin";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(417, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 38);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 466);
            Controls.Add(btnLimpiar);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cbGenero);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(textBox6);
            Controls.Add(dtpFechaNac);
            Controls.Add(label7);
            Controls.Add(lblApellidos);
            Controls.Add(lblTelefono);
            Controls.Add(label4);
            Controls.Add(lblNombre);
            Controls.Add(lblEspecialidad);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(txtPass);
            Controls.Add(textBox3);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Crear Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox textBox3;
        private TextBox txtPass;
        private TextBox txtTelefono;
        private Label label1;
        private Label lblEspecialidad;
        private Label lblNombre;
        private Label label4;
        private Label lblTelefono;
        private Label lblApellidos;
        private Label label7;
        private Label dtpFechaNac;
        private TextBox textBox6;
        private TextBox textBox9;
        private Label label9;
        private Label label10;
        private ComboBox cbGenero;
        private Button btnAceptar;
        private Button btnCancelar;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button btnLimpiar;
    }
}
