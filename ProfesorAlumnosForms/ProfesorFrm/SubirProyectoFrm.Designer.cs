namespace ProfesorFrm
{
    partial class SubirProyectoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubirProyectoFrm));
            txtNombre = new TextBox();
            textBox2 = new TextBox();
            txtAnno = new TextBox();
            dtpFecha = new DateTimePicker();
            btnLogo = new Button();
            btnProyecto = new Button();
            btnMemoria = new Button();
            cbCiclo = new ComboBox();
            cbTutor = new ComboBox();
            cbTipo = new ComboBox();
            lblNombre = new Label();
            lblAnno = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblCiclo = new Label();
            lblTutor = new Label();
            label9 = new Label();
            lblFecha = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            lblSubir = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(49, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 135);
            textBox2.TabIndex = 1;
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(316, 280);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(232, 23);
            txtAnno.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(316, 208);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(232, 23);
            dtpFecha.TabIndex = 3;
            // 
            // btnLogo
            // 
            btnLogo.Image = (Image)resources.GetObject("btnLogo.Image");
            btnLogo.Location = new Point(341, 355);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(75, 23);
            btnLogo.TabIndex = 4;
            btnLogo.UseVisualStyleBackColor = true;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnProyecto
            // 
            btnProyecto.Image = Properties.Resources.ProjectImports;
            btnProyecto.Location = new Point(341, 447);
            btnProyecto.Name = "btnProyecto";
            btnProyecto.Size = new Size(75, 23);
            btnProyecto.TabIndex = 5;
            btnProyecto.UseVisualStyleBackColor = true;
            btnProyecto.Click += btnProyecto_Click;
            // 
            // btnMemoria
            // 
            btnMemoria.Image = Properties.Resources.AddDictionary;
            btnMemoria.Location = new Point(341, 399);
            btnMemoria.Name = "btnMemoria";
            btnMemoria.Size = new Size(75, 23);
            btnMemoria.TabIndex = 6;
            btnMemoria.UseVisualStyleBackColor = true;
            btnMemoria.Click += btnMemoria_Click;
            // 
            // cbCiclo
            // 
            cbCiclo.FormattingEnabled = true;
            cbCiclo.Location = new Point(316, 129);
            cbCiclo.Name = "cbCiclo";
            cbCiclo.Size = new Size(171, 23);
            cbCiclo.TabIndex = 7;
            // 
            // cbTutor
            // 
            cbTutor.FormattingEnabled = true;
            cbTutor.Location = new Point(522, 129);
            cbTutor.Name = "cbTutor";
            cbTutor.Size = new Size(171, 23);
            cbTutor.TabIndex = 8;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(721, 129);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(171, 23);
            cbTipo.TabIndex = 9;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Location = new Point(316, 262);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(90, 15);
            lblAnno.TabIndex = 11;
            lblAnno.Text = "Año academico";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(597, 280);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(232, 23);
            txtDni.TabIndex = 12;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(597, 262);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 13;
            lblDni.Text = "DNI";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(597, 211);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(232, 23);
            txtCorreo.TabIndex = 14;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(597, 193);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(105, 15);
            lblCorreo.TabIndex = 15;
            lblCorreo.Text = "Correo electrónico";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(49, 345);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 127);
            textBox5.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 327);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 17;
            label5.Text = "Comentarios";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 165);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 18;
            label6.Text = "Resumen";
            // 
            // lblCiclo
            // 
            lblCiclo.AutoSize = true;
            lblCiclo.Location = new Point(316, 111);
            lblCiclo.Name = "lblCiclo";
            lblCiclo.Size = new Size(34, 15);
            lblCiclo.TabIndex = 19;
            lblCiclo.Text = "Ciclo";
            // 
            // lblTutor
            // 
            lblTutor.AutoSize = true;
            lblTutor.Location = new Point(522, 111);
            lblTutor.Name = "lblTutor";
            lblTutor.Size = new Size(35, 15);
            lblTutor.TabIndex = 20;
            lblTutor.Text = "Tutor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(720, 111);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 21;
            label9.Text = "Tipo";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(316, 190);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 22;
            lblFecha.Text = "Fecha";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(520, 384);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 38);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(636, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 38);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblSubir
            // 
            lblSubir.AutoSize = true;
            lblSubir.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubir.Location = new Point(316, 27);
            lblSubir.Name = "lblSubir";
            lblSubir.Size = new Size(280, 50);
            lblSubir.TabIndex = 26;
            lblSubir.Text = "Subir Proyecto";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(341, 337);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 27;
            label12.Text = "Cargar Logo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(341, 381);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 28;
            label13.Text = "Cargar Memoria";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(341, 429);
            label14.Name = "label14";
            label14.Size = new Size(96, 15);
            label14.TabIndex = 29;
            label14.Text = "Cargar Proyecto";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(753, 384);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 38);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // SubirProyectoFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 497);
            Controls.Add(btnCancelar);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lblSubir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(lblFecha);
            Controls.Add(label9);
            Controls.Add(lblTutor);
            Controls.Add(lblCiclo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(lblAnno);
            Controls.Add(lblNombre);
            Controls.Add(cbTipo);
            Controls.Add(cbTutor);
            Controls.Add(cbCiclo);
            Controls.Add(btnMemoria);
            Controls.Add(btnProyecto);
            Controls.Add(btnLogo);
            Controls.Add(dtpFecha);
            Controls.Add(txtAnno);
            Controls.Add(textBox2);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SubirProyectoFrm";
            Text = "SubirProyectoFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox textBox2;
        private TextBox txtAnno;
        private DateTimePicker dtpFecha;
        private Button btnLogo;
        private Button btnProyecto;
        private Button btnMemoria;
        private ComboBox cbCiclo;
        private ComboBox cbTutor;
        private ComboBox cbTipo;
        private Label lblNombre;
        private Label lblAnno;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox textBox5;
        private Label label5;
        private Label label6;
        private Label lblCiclo;
        private Label lblTutor;
        private Label label9;
        private Label lblFecha;
        private Button btnAceptar;
        private Button btnLimpiar;
        
        private Label lblSubir;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnCancelar;
    }
}