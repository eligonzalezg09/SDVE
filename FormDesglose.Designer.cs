namespace Miniproyecto1
{
    partial class FormDesglose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesglose));
            PEncabezado = new Panel();
            LNombreSistema = new Label();
            LTitulo = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LInstruccion = new Label();
            panel1 = new Panel();
            BConsultar = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            CBCentro = new ComboBox();
            CBCarrera = new ComboBox();
            CBGrupo = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            DGVResultados = new DataGridView();
            ColConvocatoria = new DataGridViewTextBoxColumn();
            ColCandidato = new DataGridViewTextBoxColumn();
            ColVotos = new DataGridViewTextBoxColumn();
            ColPorcentaje = new DataGridViewTextBoxColumn();
            label9 = new Label();
            TBAbstencionismo = new TextBox();
            label17 = new Label();
            TBParticipacion = new TextBox();
            label16 = new Label();
            TBTotalVotos = new TextBox();
            label3 = new Label();
            BExportar = new Button();
            BRegresar = new Button();
            PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVResultados).BeginInit();
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
            PEncabezado.TabIndex = 2;
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 905);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(171, 199, 245);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 61, 103);
            label1.Location = new Point(383, 164);
            label1.Name = "label1";
            label1.Size = new Size(819, 53);
            label1.TabIndex = 19;
            label1.Text = "Desglose de resultados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LInstruccion
            // 
            LInstruccion.AutoSize = true;
            LInstruccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LInstruccion.ForeColor = Color.FromArgb(24, 61, 103);
            LInstruccion.Location = new Point(526, 226);
            LInstruccion.Name = "LInstruccion";
            LInstruccion.Size = new Size(500, 23);
            LInstruccion.TabIndex = 20;
            LInstruccion.Text = "Consulta los resultados por grupo, carrera  y centro universitario";
            // 
            // panel1
            // 
            panel1.Controls.Add(BConsultar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CBCentro);
            panel1.Controls.Add(CBCarrera);
            panel1.Controls.Add(CBGrupo);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(383, 282);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 201);
            panel1.TabIndex = 21;
            // 
            // BConsultar
            // 
            BConsultar.AutoSize = true;
            BConsultar.BackgroundImage = (Image)resources.GetObject("BConsultar.BackgroundImage");
            BConsultar.BackgroundImageLayout = ImageLayout.Zoom;
            BConsultar.Location = new Point(594, 134);
            BConsultar.Name = "BConsultar";
            BConsultar.Size = new Size(168, 61);
            BConsultar.TabIndex = 22;
            BConsultar.UseVisualStyleBackColor = true;
            BConsultar.Click += BConsultar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(24, 61, 103);
            label6.Location = new Point(564, 67);
            label6.Name = "label6";
            label6.Size = new Size(198, 28);
            label6.TabIndex = 27;
            label6.Text = "Centro Universitario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(24, 61, 103);
            label5.Location = new Point(314, 67);
            label5.Name = "label5";
            label5.Size = new Size(81, 28);
            label5.TabIndex = 26;
            label5.Text = "Carrera:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(24, 61, 103);
            label4.Location = new Point(53, 67);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 22;
            label4.Text = "Grupo:";
            // 
            // CBCentro
            // 
            CBCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCentro.FormattingEnabled = true;
            CBCentro.Location = new Point(564, 98);
            CBCentro.Name = "CBCentro";
            CBCentro.Size = new Size(198, 28);
            CBCentro.TabIndex = 25;
            // 
            // CBCarrera
            // 
            CBCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCarrera.FormattingEnabled = true;
            CBCarrera.Location = new Point(314, 98);
            CBCarrera.Name = "CBCarrera";
            CBCarrera.Size = new Size(195, 28);
            CBCarrera.TabIndex = 24;
            // 
            // CBGrupo
            // 
            CBGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGrupo.FormattingEnabled = true;
            CBGrupo.Location = new Point(53, 98);
            CBGrupo.Name = "CBGrupo";
            CBGrupo.Size = new Size(195, 28);
            CBGrupo.TabIndex = 23;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(24, 61, 103);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(819, 40);
            label2.TabIndex = 22;
            label2.Text = "Filtrar resultados";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(DGVResultados);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(383, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(819, 309);
            panel2.TabIndex = 28;
            // 
            // DGVResultados
            // 
            DGVResultados.AllowUserToAddRows = false;
            DGVResultados.AllowUserToDeleteRows = false;
            DGVResultados.AllowUserToOrderColumns = true;
            DGVResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVResultados.BackgroundColor = SystemColors.GradientInactiveCaption;
            DGVResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVResultados.Columns.AddRange(new DataGridViewColumn[] { ColConvocatoria, ColCandidato, ColVotos, ColPorcentaje });
            DGVResultados.GridColor = SystemColors.InactiveCaption;
            DGVResultados.Location = new Point(23, 52);
            DGVResultados.Name = "DGVResultados";
            DGVResultados.ReadOnly = true;
            DGVResultados.RowHeadersVisible = false;
            DGVResultados.RowHeadersWidth = 51;
            DGVResultados.Size = new Size(778, 237);
            DGVResultados.TabIndex = 23;
            // 
            // ColConvocatoria
            // 
            ColConvocatoria.HeaderText = "Convocatoria";
            ColConvocatoria.MinimumWidth = 6;
            ColConvocatoria.Name = "ColConvocatoria";
            ColConvocatoria.ReadOnly = true;
            // 
            // ColCandidato
            // 
            ColCandidato.HeaderText = "Candidato";
            ColCandidato.MinimumWidth = 6;
            ColCandidato.Name = "ColCandidato";
            ColCandidato.ReadOnly = true;
            // 
            // ColVotos
            // 
            ColVotos.HeaderText = "Votos";
            ColVotos.MinimumWidth = 6;
            ColVotos.Name = "ColVotos";
            ColVotos.ReadOnly = true;
            // 
            // ColPorcentaje
            // 
            ColPorcentaje.HeaderText = "Porcentaje";
            ColPorcentaje.MinimumWidth = 6;
            ColPorcentaje.Name = "ColPorcentaje";
            ColPorcentaje.ReadOnly = true;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(24, 61, 103);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(819, 40);
            label9.TabIndex = 22;
            label9.Text = "Resultados";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBAbstencionismo
            // 
            TBAbstencionismo.Location = new Point(1032, 853);
            TBAbstencionismo.Name = "TBAbstencionismo";
            TBAbstencionismo.ReadOnly = true;
            TBAbstencionismo.Size = new Size(101, 27);
            TBAbstencionismo.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(24, 61, 103);
            label17.Location = new Point(868, 855);
            label17.Name = "label17";
            label17.Size = new Size(158, 28);
            label17.TabIndex = 33;
            label17.Text = "Abstencionismo";
            // 
            // TBParticipacion
            // 
            TBParticipacion.Location = new Point(1032, 802);
            TBParticipacion.Name = "TBParticipacion";
            TBParticipacion.ReadOnly = true;
            TBParticipacion.Size = new Size(101, 27);
            TBParticipacion.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(24, 61, 103);
            label16.Location = new Point(899, 801);
            label16.Name = "label16";
            label16.Size = new Size(127, 28);
            label16.TabIndex = 31;
            label16.Text = "Participación";
            // 
            // TBTotalVotos
            // 
            TBTotalVotos.Location = new Point(607, 805);
            TBTotalVotos.Name = "TBTotalVotos";
            TBTotalVotos.ReadOnly = true;
            TBTotalVotos.Size = new Size(101, 27);
            TBTotalVotos.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(24, 61, 103);
            label3.Location = new Point(474, 804);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 35;
            label3.Text = "Total Votos";
            // 
            // BExportar
            // 
            BExportar.AutoSize = true;
            BExportar.BackColor = SystemColors.ButtonHighlight;
            BExportar.BackgroundImage = (Image)resources.GetObject("BExportar.BackgroundImage");
            BExportar.BackgroundImageLayout = ImageLayout.Zoom;
            BExportar.Location = new Point(926, 895);
            BExportar.Name = "BExportar";
            BExportar.Size = new Size(243, 71);
            BExportar.TabIndex = 37;
            BExportar.UseVisualStyleBackColor = false;
            // 
            // BRegresar
            // 
            BRegresar.AutoSize = true;
            BRegresar.BackColor = SystemColors.ButtonHighlight;
            BRegresar.BackgroundImage = (Image)resources.GetObject("BRegresar.BackgroundImage");
            BRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            BRegresar.Location = new Point(421, 895);
            BRegresar.Name = "BRegresar";
            BRegresar.Size = new Size(232, 68);
            BRegresar.TabIndex = 38;
            BRegresar.UseVisualStyleBackColor = false;
            BRegresar.Click += BRegresar_Click;
            // 
            // FormDesglose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 971);
            Controls.Add(BRegresar);
            Controls.Add(BExportar);
            Controls.Add(TBTotalVotos);
            Controls.Add(label3);
            Controls.Add(TBAbstencionismo);
            Controls.Add(label17);
            Controls.Add(TBParticipacion);
            Controls.Add(label16);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(LInstruccion);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(PEncabezado);
            MinimizeBox = false;
            MinimumSize = new Size(1289, 1018);
            Name = "FormDesglose";
            Text = "Desglose de Resultados - SDVE";
            Load += FormDesglose_Load;
            PEncabezado.ResumeLayout(false);
            PEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PEncabezado;
        private Label LNombreSistema;
        private Label LTitulo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label LInstruccion;
        private Panel panel1;
        private Label label2;
        private ComboBox CBCentro;
        private ComboBox CBCarrera;
        private ComboBox CBGrupo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BConsultar;
        private Panel panel2;
        private Label label9;
        private DataGridView DGVResultados;
        private DataGridViewTextBoxColumn ColConvocatoria;
        private DataGridViewTextBoxColumn ColCandidato;
        private DataGridViewTextBoxColumn ColVotos;
        private DataGridViewTextBoxColumn ColPorcentaje;
        private TextBox TBAbstencionismo;
        private Label label17;
        private TextBox TBParticipacion;
        private Label label16;
        private TextBox TBTotalVotos;
        private Label label3;
        private Button BExportar;
        private Button BRegresar;
    }
}