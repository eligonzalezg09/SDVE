namespace Miniproyecto1
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            PEncabezado = new Panel();
            LNombreSistema = new Label();
            LTitulo = new Label();
            LTituloPantalla = new Label();
            LInstruccion = new Label();
            pictureBox1 = new PictureBox();
            PAlumno = new Panel();
            TBNombre = new TextBox();
            CBCentro = new ComboBox();
            CBCarrera = new ComboBox();
            CBGrupo = new ComboBox();
            TBID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PConvocatorias = new Panel();
            panel2 = new Panel();
            label14 = new Label();
            pictureBox4 = new PictureBox();
            CHRepresentantes = new CheckBox();
            panel1 = new Panel();
            label12 = new Label();
            pictureBox3 = new PictureBox();
            CHConsejoUniversitario = new CheckBox();
            PTarjetaSociedad = new Panel();
            label9 = new Label();
            pictureBox2 = new PictureBox();
            CHSociedad = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            BLimpiar = new Button();
            BContinuar = new Button();
            BResultados = new Button();
            PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PAlumno.SuspendLayout();
            PConvocatorias.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            PTarjetaSociedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PEncabezado
            // 
            PEncabezado.BackColor = Color.FromArgb(24, 61, 103);
            PEncabezado.Controls.Add(LNombreSistema);
            PEncabezado.Controls.Add(LTitulo);
            PEncabezado.Dock = DockStyle.Top;
            PEncabezado.Location = new Point(0, 0);
            PEncabezado.Name = "PEncabezado";
            PEncabezado.Size = new Size(1271, 150);
            PEncabezado.TabIndex = 0;
            // 
            // LNombreSistema
            // 
            LNombreSistema.AutoSize = true;
            LNombreSistema.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreSistema.ForeColor = SystemColors.ControlLightLight;
            LNombreSistema.Location = new Point(474, 94);
            LNombreSistema.Name = "LNombreSistema";
            LNombreSistema.Size = new Size(365, 23);
            LNombreSistema.TabIndex = 1;
            LNombreSistema.Text = "SISTEMA DIGITAL DE VOTACIÓN ESTUDIANTIL";
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LTitulo.ForeColor = SystemColors.ButtonFace;
            LTitulo.Location = new Point(575, 9);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(154, 67);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "SDVE";
            // 
            // LTituloPantalla
            // 
            LTituloPantalla.AutoSize = true;
            LTituloPantalla.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTituloPantalla.ForeColor = Color.FromArgb(24, 61, 103);
            LTituloPantalla.Location = new Point(330, 167);
            LTituloPantalla.Name = "LTituloPantalla";
            LTituloPantalla.Size = new Size(443, 41);
            LTituloPantalla.TabIndex = 1;
            LTituloPantalla.Text = "Registro y selección de votación";
            // 
            // LInstruccion
            // 
            LInstruccion.AutoSize = true;
            LInstruccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LInstruccion.ForeColor = Color.FromArgb(24, 61, 103);
            LInstruccion.Location = new Point(330, 225);
            LInstruccion.Name = "LInstruccion";
            LInstruccion.Size = new Size(592, 23);
            LInstruccion.TabIndex = 2;
            LInstruccion.Text = "Ingresa tus datos y selecciona las convocatorias en las que deseas participar.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-1, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 905);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // PAlumno
            // 
            PAlumno.AccessibleRole = AccessibleRole.Pane;
            PAlumno.Controls.Add(TBNombre);
            PAlumno.Controls.Add(CBCentro);
            PAlumno.Controls.Add(CBCarrera);
            PAlumno.Controls.Add(CBGrupo);
            PAlumno.Controls.Add(TBID);
            PAlumno.Controls.Add(label6);
            PAlumno.Controls.Add(label5);
            PAlumno.Controls.Add(label4);
            PAlumno.Controls.Add(label3);
            PAlumno.Controls.Add(label2);
            PAlumno.Location = new Point(330, 315);
            PAlumno.Name = "PAlumno";
            PAlumno.Size = new Size(437, 422);
            PAlumno.TabIndex = 4;
            // 
            // TBNombre
            // 
            TBNombre.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TBNombre.ForeColor = SystemColors.ControlText;
            TBNombre.Location = new Point(23, 135);
            TBNombre.Name = "TBNombre";
            TBNombre.Size = new Size(391, 32);
            TBNombre.TabIndex = 10;
            // 
            // CBCentro
            // 
            CBCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCentro.FormattingEnabled = true;
            CBCentro.Items.AddRange(new object[] { "Centro de Ciencias Basicas", "Centro de Ciencias Economicas", "Centro de Ciencias de la Salud", "Centro de Ciencias Sociales y Humanidades " });
            CBCentro.Location = new Point(23, 374);
            CBCentro.Name = "CBCentro";
            CBCentro.Size = new Size(391, 28);
            CBCentro.TabIndex = 9;
            // 
            // CBCarrera
            // 
            CBCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCarrera.FormattingEnabled = true;
            CBCarrera.Items.AddRange(new object[] { "Lic. Informatica y Tecnologias Computacionales ", "Lic. Recursos Humanos", "Lic. Medico Cirujano", "Lic. Derecho" });
            CBCarrera.Location = new Point(23, 295);
            CBCarrera.Name = "CBCarrera";
            CBCarrera.Size = new Size(391, 28);
            CBCarrera.TabIndex = 8;
            // 
            // CBGrupo
            // 
            CBGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGrupo.FormattingEnabled = true;
            CBGrupo.Items.AddRange(new object[] { "1A", "2A", "3A", "4A", "5A", "6A", "7A", "8A", "9A", "10A" });
            CBGrupo.Location = new Point(23, 220);
            CBGrupo.Name = "CBGrupo";
            CBGrupo.Size = new Size(391, 28);
            CBGrupo.TabIndex = 7;
            // 
            // TBID
            // 
            TBID.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TBID.ForeColor = SystemColors.ControlText;
            TBID.Location = new Point(23, 55);
            TBID.Name = "TBID";
            TBID.Size = new Size(391, 32);
            TBID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(24, 61, 103);
            label6.Location = new Point(23, 332);
            label6.Name = "label6";
            label6.Size = new Size(198, 28);
            label6.TabIndex = 4;
            label6.Text = "Centro Universitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(24, 61, 103);
            label5.Location = new Point(23, 255);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 3;
            label5.Text = "Carrera:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(24, 61, 103);
            label4.Location = new Point(23, 180);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 2;
            label4.Text = "Grupo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(24, 61, 103);
            label3.Location = new Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 1;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(24, 61, 103);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 0;
            label2.Text = "ID del Alumno:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(171, 199, 245);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 61, 103);
            label1.Location = new Point(330, 275);
            label1.Name = "label1";
            label1.Size = new Size(437, 34);
            label1.TabIndex = 5;
            label1.Text = "Datos del Alumno";
            // 
            // PConvocatorias
            // 
            PConvocatorias.Controls.Add(panel2);
            PConvocatorias.Controls.Add(panel1);
            PConvocatorias.Controls.Add(PTarjetaSociedad);
            PConvocatorias.Controls.Add(label8);
            PConvocatorias.Location = new Point(801, 315);
            PConvocatorias.Name = "PConvocatorias";
            PConvocatorias.Size = new Size(437, 422);
            PConvocatorias.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(235, 241, 248);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(CHRepresentantes);
            panel2.Location = new Point(25, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 74);
            panel2.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(24, 61, 103);
            label14.Location = new Point(134, 26);
            label14.Name = "label14";
            label14.Size = new Size(224, 23);
            label14.TabIndex = 10;
            label14.Text = "Consejo de Representantes";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(57, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 59);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // CHRepresentantes
            // 
            CHRepresentantes.AutoSize = true;
            CHRepresentantes.Location = new Point(21, 28);
            CHRepresentantes.Name = "CHRepresentantes";
            CHRepresentantes.Size = new Size(18, 17);
            CHRepresentantes.TabIndex = 11;
            CHRepresentantes.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(235, 241, 248);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(CHConsejoUniversitario);
            panel1.Location = new Point(25, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 74);
            panel1.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(24, 61, 103);
            label12.Location = new Point(134, 21);
            label12.Name = "label12";
            label12.Size = new Size(205, 28);
            label12.TabIndex = 10;
            label12.Text = "Consejo Universitario";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // CHConsejoUniversitario
            // 
            CHConsejoUniversitario.AutoSize = true;
            CHConsejoUniversitario.Location = new Point(21, 28);
            CHConsejoUniversitario.Name = "CHConsejoUniversitario";
            CHConsejoUniversitario.Size = new Size(18, 17);
            CHConsejoUniversitario.TabIndex = 11;
            CHConsejoUniversitario.UseVisualStyleBackColor = true;
            // 
            // PTarjetaSociedad
            // 
            PTarjetaSociedad.BackColor = Color.FromArgb(235, 241, 248);
            PTarjetaSociedad.Controls.Add(label9);
            PTarjetaSociedad.Controls.Add(pictureBox2);
            PTarjetaSociedad.Controls.Add(CHSociedad);
            PTarjetaSociedad.Location = new Point(25, 96);
            PTarjetaSociedad.Name = "PTarjetaSociedad";
            PTarjetaSociedad.Size = new Size(372, 74);
            PTarjetaSociedad.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(24, 61, 103);
            label9.Location = new Point(134, 22);
            label9.Name = "label9";
            label9.Size = new Size(210, 28);
            label9.TabIndex = 10;
            label9.Text = "Sociedad de Alumnos";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // CHSociedad
            // 
            CHSociedad.AutoSize = true;
            CHSociedad.Location = new Point(21, 28);
            CHSociedad.Name = "CHSociedad";
            CHSociedad.Size = new Size(18, 17);
            CHSociedad.TabIndex = 11;
            CHSociedad.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(24, 61, 103);
            label8.Location = new Point(25, 15);
            label8.Name = "label8";
            label8.Size = new Size(367, 56);
            label8.TabIndex = 10;
            label8.Text = "Selecciona una o mas convocatorias en\r\nlas que deseas votar";
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(171, 199, 245);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(24, 61, 103);
            label7.Location = new Point(801, 275);
            label7.Name = "label7";
            label7.Size = new Size(437, 34);
            label7.TabIndex = 7;
            label7.Text = "Convocatorias Disponibles";
            // 
            // BLimpiar
            // 
            BLimpiar.AutoSize = true;
            BLimpiar.BackgroundImage = (Image)resources.GetObject("BLimpiar.BackgroundImage");
            BLimpiar.BackgroundImageLayout = ImageLayout.Zoom;
            BLimpiar.Location = new Point(380, 793);
            BLimpiar.Name = "BLimpiar";
            BLimpiar.Size = new Size(217, 64);
            BLimpiar.TabIndex = 8;
            BLimpiar.UseVisualStyleBackColor = true;
            BLimpiar.Click += BLimpiar_Click;
            // 
            // BContinuar
            // 
            BContinuar.AutoSize = true;
            BContinuar.BackgroundImage = (Image)resources.GetObject("BContinuar.BackgroundImage");
            BContinuar.BackgroundImageLayout = ImageLayout.Zoom;
            BContinuar.Location = new Point(960, 795);
            BContinuar.Name = "BContinuar";
            BContinuar.Size = new Size(249, 61);
            BContinuar.TabIndex = 9;
            BContinuar.UseVisualStyleBackColor = true;
            BContinuar.Click += BContinuar_Click;
            // 
            // BResultados
            // 
            BResultados.AutoSize = true;
            BResultados.BackgroundImage = (Image)resources.GetObject("BResultados.BackgroundImage");
            BResultados.BackgroundImageLayout = ImageLayout.Zoom;
            BResultados.Location = new Point(655, 792);
            BResultados.Name = "BResultados";
            BResultados.Size = new Size(267, 64);
            BResultados.TabIndex = 10;
            BResultados.UseVisualStyleBackColor = true;
            BResultados.Click += BResultados_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 252);
            ClientSize = new Size(1271, 878);
            Controls.Add(BResultados);
            Controls.Add(BContinuar);
            Controls.Add(BLimpiar);
            Controls.Add(label7);
            Controls.Add(PConvocatorias);
            Controls.Add(label1);
            Controls.Add(PAlumno);
            Controls.Add(pictureBox1);
            Controls.Add(LInstruccion);
            Controls.Add(LTituloPantalla);
            Controls.Add(PEncabezado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1289, 925);
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Digital de Votación Estudiantil";
            PEncabezado.ResumeLayout(false);
            PEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PAlumno.ResumeLayout(false);
            PAlumno.PerformLayout();
            PConvocatorias.ResumeLayout(false);
            PConvocatorias.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            PTarjetaSociedad.ResumeLayout(false);
            PTarjetaSociedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PEncabezado;
        private Label LTitulo;
        private Label LNombreSistema;
        private Label LTituloPantalla;
        private Label LInstruccion;
        private PictureBox pictureBox1;
        private Panel PAlumno;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox CBCentro;
        private ComboBox CBCarrera;
        private TextBox TBID;
        private Panel PConvocatorias;
        private Label label7;
        private Label label8;
        private CheckBox CHSociedad;
        private Panel PTarjetaSociedad;
        private PictureBox pictureBox2;
        private Label label9;
        private Panel panel1;
        private Label label12;
        private PictureBox pictureBox3;
        private CheckBox CHConsejoUniversitario;
        private Panel panel2;
        private Label label14;
        private PictureBox pictureBox4;
        private CheckBox CHRepresentantes;
        private Button BLimpiar;
        private Button BContinuar;
        private TextBox TBNombre;
        private ComboBox CBGrupo;
        private Button BResultados;
    }
}
