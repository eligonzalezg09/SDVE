using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Miniproyecto1
{
    public partial class FormGrafica : Form
    {
        public FormGrafica()
        {
            InitializeComponent();
        }

        private void FormGrafica_Load(object sender, EventArgs e)
        {
            MostrarGrafica();
        }

        private void MostrarGrafica()
        {
            PGrafica.Controls.Clear();

            List<Voto> votos = GestorVotacion.ObtenerVotos();

            if (votos.Count == 0)
            {
                Label mensaje = new Label();

                mensaje.Text = "No hay votos registrados para mostrar.";
                mensaje.AutoSize = true;
                mensaje.Font = new Font("Segoe UI", 12);
                mensaje.Location = new Point(30, 30);

                PGrafica.Controls.Add(mensaje);
                return;
            }

            var resultados = votos
                .GroupBy(v => v.Candidato)
                .Select(g => new
                {
                    Candidato = g.Key,
                    Votos = g.Count()
                })
                .OrderByDescending(r => r.Votos)
                .ToList();

            int votoMayor = resultados.Max(r => r.Votos);

            int posicionY = 25;

            foreach (var resultado in resultados)
            {
                // Nombre del candidato.
                Label LCandidato = new Label();

                LCandidato.Text = resultado.Candidato;
                LCandidato.Font = new Font("Segoe UI", 10);
                LCandidato.AutoSize = false;
                LCandidato.TextAlign = ContentAlignment.MiddleLeft;
                LCandidato.Location = new Point(20, posicionY);
                LCandidato.Size = new Size(180, 30);

                PGrafica.Controls.Add(LCandidato);

                // Barra de votos.
                Panel PBarra = new Panel();

                int anchoBarra =
                    (int)((double)resultado.Votos / votoMayor * 350);

                PBarra.Location = new Point(210, posicionY + 3);
                PBarra.Size = new Size(anchoBarra, 24);
                PBarra.BackColor = Color.FromArgb(24, 61, 103);

                PGrafica.Controls.Add(PBarra);

                // Cantidad de votos.
                Label LVotos = new Label();

                LVotos.Text = resultado.Votos.ToString();
                LVotos.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                LVotos.AutoSize = true;
                LVotos.Location =
                    new Point(220 + anchoBarra, posicionY + 5);

                PGrafica.Controls.Add(LVotos);

                posicionY += 45;
            }
        }

        private void BRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
