using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Miniproyecto1
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            List<Voto> votos = GestorVotacion.ObtenerVotos();

            // Sociedad de Alumnos
            TBSAna.Text = votos.Count(v =>
                v.Convocatoria == "Sociedad de Alumnos" &&
                v.Candidato == "Ana Torres").ToString();

            TBSLuis.Text = votos.Count(v =>
                v.Convocatoria == "Sociedad de Alumnos" &&
                v.Candidato == "Luis Herrera").ToString();

            TBSMariana.Text = votos.Count(v =>
                v.Convocatoria == "Sociedad de Alumnos" &&
                v.Candidato == "Mariana Lopez").ToString();

            TBSOtros.Text = votos.Count(v =>
                v.Convocatoria == "Sociedad de Alumnos" &&
                v.Candidato != "Ana Torres" &&
                v.Candidato != "Luis Herrera" &&
                v.Candidato != "Mariana Lopez").ToString();

            // Consejo Universitario
            TBCarlos.Text = votos.Count(v =>
                v.Convocatoria == "Consejo Universitario" &&
                v.Candidato == "Carlos Mendez").ToString();

            TBValeria.Text = votos.Count(v =>
                v.Convocatoria == "Consejo Universitario" &&
                v.Candidato == "Valeria Sanchez").ToString();

            TBJorge.Text = votos.Count(v =>
                v.Convocatoria == "Consejo Universitario" &&
                v.Candidato == "Jorge Ramirez").ToString();

            TBCOtros.Text = votos.Count(v =>
                v.Convocatoria == "Consejo Universitario" &&
                v.Candidato != "Carlos Mendez" &&
                v.Candidato != "Valeria Sanchez" &&
                v.Candidato != "Jorge Ramirez").ToString();

            // Consejo de Representantes
            TBSofia.Text = votos.Count(v =>
                v.Convocatoria == "Consejo de Representantes" &&
                v.Candidato == "Sofia Ruiz").ToString();

            TBDiego.Text = votos.Count(v =>
                v.Convocatoria == "Consejo de Representantes" &&
                v.Candidato == "Diego Morales").ToString();

            TBFernanda.Text = votos.Count(v =>
                v.Convocatoria == "Consejo de Representantes" &&
                v.Candidato == "Fernanda Castro").ToString();

            TBROtros.Text = votos.Count(v =>
                v.Convocatoria == "Consejo de Representantes" &&
                v.Candidato != "Sofia Ruiz" &&
                v.Candidato != "Diego Morales" &&
                v.Candidato != "Fernanda Castro").ToString();

            // Participación y abstencionismo.
            int totalAlumnos = 20;

            int alumnosQueVotaron = votos
                .Select(v => v.IdAlumno)
                .Distinct()
                .Count();

            double participacion =
                (double)alumnosQueVotaron / totalAlumnos * 100;

            double abstencionismo = 100 - participacion;

            TBParticipacion.Text =
                participacion.ToString("0.00") + " %";

            TBAbstencionismo.Text =
                abstencionismo.ToString("0.00") + " %";
        }

        private void BVerDesglose_Click(object sender, EventArgs e)
        {
            FormDesglose desglose = new FormDesglose();

            this.Hide();
            desglose.ShowDialog();
            this.Show();
        }

        private void BExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();

            guardarArchivo.Filter =
                "Archivo CSV (*.csv)|*.csv";

            guardarArchivo.FileName =
                "Resultados_Generales_SDVE.csv";

            guardarArchivo.Title =
                "Guardar resultados generales";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo =
                    new StreamWriter(guardarArchivo.FileName))
                {
                    archivo.WriteLine(
                        "Convocatoria,Candidato,Votos");

                    // Sociedad de Alumnos
                    archivo.WriteLine(
                        $"Sociedad de Alumnos,Ana Torres,{TBSAna.Text}");

                    archivo.WriteLine(
                        $"Sociedad de Alumnos,Luis Herrera,{TBSLuis.Text}");

                    archivo.WriteLine(
                        $"Sociedad de Alumnos,Mariana Lopez,{TBSMariana.Text}");

                    archivo.WriteLine(
                        $"Sociedad de Alumnos,Otros,{TBSOtros.Text}");

                    // Consejo Universitario
                    archivo.WriteLine(
                        $"Consejo Universitario,Carlos Mendez,{TBCarlos.Text}");

                    archivo.WriteLine(
                        $"Consejo Universitario,Valeria Sanchez,{TBValeria.Text}");

                    archivo.WriteLine(
                        $"Consejo Universitario,Jorge Ramirez,{TBJorge.Text}");

                    archivo.WriteLine(
                        $"Consejo Universitario,Otros,{TBCOtros.Text}");

                    // Consejo de Representantes
                    archivo.WriteLine(
                        $"Consejo de Representantes,Sofia Ruiz,{TBSofia.Text}");

                    archivo.WriteLine(
                        $"Consejo de Representantes,Diego Morales,{TBDiego.Text}");

                    archivo.WriteLine(
                        $"Consejo de Representantes,Fernanda Castro,{TBFernanda.Text}");

                    archivo.WriteLine(
                        $"Consejo de Representantes,Otros,{TBROtros.Text}");
                }

                MessageBox.Show(
                    "Los resultados generales fueron exportados correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BGrafica_Click(object sender, EventArgs e)
        {
            FormGrafica grafica = new FormGrafica();

            this.Hide();
            grafica.ShowDialog();
            this.Show();
        }
    }
}