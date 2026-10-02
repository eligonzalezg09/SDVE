namespace Miniproyecto1
{
    partial class FormGrafica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrafica));
            PEncabezado = new Panel();
            LNombreSistema = new Label();
            LTitulo = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            BRegresar = new Button();
            PGrafica = new Panel();
            PEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            PEncabezado.TabIndex = 3;
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
            pictureBox1.Location = new Point(0, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 905);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(171, 199, 245);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 61, 103);
            label1.Location = new Point(386, 169);
            label1.Name = "label1";
            label1.Size = new Size(819, 53);
            label1.TabIndex = 20;
            label1.Text = "Visualización gráfica de resultados";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BRegresar
            // 
            BRegresar.AutoSize = true;
            BRegresar.BackColor = SystemColors.ButtonHighlight;
            BRegresar.BackgroundImage = (Image)resources.GetObject("BRegresar.BackgroundImage");
            BRegresar.BackgroundImageLayout = ImageLayout.Zoom;
            BRegresar.Location = new Point(665, 899);
            BRegresar.Name = "BRegresar";
            BRegresar.Size = new Size(232, 68);
            BRegresar.TabIndex = 39;
            BRegresar.UseVisualStyleBackColor = false;
            BRegresar.Click += BRegresar_Click;
            // 
            // PGrafica
            // 
            PGrafica.AutoScroll = true;
            PGrafica.Location = new Point(370, 255);
            PGrafica.Name = "PGrafica";
            PGrafica.Size = new Size(859, 621);
            PGrafica.TabIndex = 40;
            // 
            // FormGrafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 979);
            Controls.Add(PGrafica);
            Controls.Add(BRegresar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(PEncabezado);
            MinimumSize = new Size(1289, 1018);
            Name = "FormGrafica";
            Text = "FormGrafica";
            Load += FormGrafica_Load;
            PEncabezado.ResumeLayout(false);
            PEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PEncabezado;
        private Label LNombreSistema;
        private Label LTitulo;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BRegresar;
        private Panel PGrafica;
    }
}