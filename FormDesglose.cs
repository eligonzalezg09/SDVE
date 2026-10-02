using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Miniproyecto1
{
    public partial class FormDesglose : Form
    {
        public FormDesglose()
        {
            InitializeComponent();
        }

        private void FormDesglose_Load(object sender, EventArgs e)
        {
            // Carga las opciones de grupo.
            CBGrupo.Items.AddRange(new string[]
            {
                "1A",
                "2A",
                "3A",
                "4A",
                "5A",
                "6A",
                "7A",
                "8A",
                "9A",
                "10A"
            });

            // Carga las opciones de carrera.
            CBCarrera.Items.AddRange(new string[]
            {
                "Lic. Informatica y Tecnologias Computacionales",
                "Lic. Recursos Humanos",
                "Lic. Medico Cirujano",
                "Lic. Derecho"
            });

            // Carga las opciones de centro universitario.
            CBCentro.Items.AddRange(new string[]
            {
                "Centro de Ciencias Basicas",
                "Centro de Ciencias Economicas",
                "Centro de Ciencias de la Salud",
                "Centro de Ciencias Sociales y Humanidades"
            });

            // Inicia los filtros sin selección.
            CBGrupo.SelectedIndex = -1;
            CBCarrera.SelectedIndex = -1;
            CBCentro.SelectedIndex = -1;

            TBTotalVotos.Text = "0";
            TBParticipacion.Text = "0.00 %";
            TBAbstencionismo.Text = "100.00 %";
        }

        private void BConsultar_Click(object sender, EventArgs e)
        {
            List<Voto> votos = GestorVotacion.ObtenerVotos();

            // Aplica los filtros seleccionados.
            IEnumerable<Voto> votosFiltrados = votos;

            if (CBGrupo.SelectedIndex != -1)
            {
                votosFiltrados = votosFiltrados.Where(v =>
                    v.Grupo == CBGrupo.Text);
            }

            if (CBCarrera.SelectedIndex != -1)
            {
                votosFiltrados = votosFiltrados.Where(v =>
                    v.Carrera == CBCarrera.Text);
            }

            if (CBCentro.SelectedIndex != -1)
            {
                votosFiltrados = votosFiltrados.Where(v =>
                    v.CentroUniversitario == CBCentro.Text);
            }

            List<Voto> listaFiltrada = votosFiltrados.ToList();

            // Limpia los resultados anteriores.
            DGVResultados.Rows.Clear();

            // Agrupa los votos por convocatoria y candidato.
            var resultados = listaFiltrada
                .GroupBy(v => new
                {
                    v.Convocatoria,
                    v.Candidato
                })
                .Select(g => new
                {
                    Convocatoria = g.Key.Convocatoria,
                    Candidato = g.Key.Candidato,
                    Votos = g.Count()
                })
                .OrderBy(r => r.Convocatoria)
                .ThenByDescending(r => r.Votos);

            int totalVotos = listaFiltrada.Count;

            // Muestra los resultados.
            foreach (var resultado in resultados)
            {
                double porcentaje = 0;

                if (totalVotos > 0)
                {
                    porcentaje =
                        (double)resultado.Votos / totalVotos * 100;
                }

                DGVResultados.Rows.Add(
                    resultado.Convocatoria,
                    resultado.Candidato,
                    resultado.Votos,
                    porcentaje.ToString("0.00") + " %"
                );
            }

            TBTotalVotos.Text = totalVotos.ToString();

            // Calcula la participación y el abstencionismo.
            int totalAlumnos = 20;

            int alumnosQueVotaron = listaFiltrada
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

        private void BRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BExportar_Click(object sender, EventArgs e)
        {
            if (DGVResultados.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No hay resultados para exportar.",
                    "Exportación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            SaveFileDialog guardarArchivo = new SaveFileDialog();

            guardarArchivo.Filter = "Archivo CSV (*.csv)|*.csv";
            guardarArchivo.FileName = "Resultados_SDVE.csv";
            guardarArchivo.Title = "Guardar resultados";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo =
                    new StreamWriter(guardarArchivo.FileName))
                {
                    archivo.WriteLine(
                        "Convocatoria,Candidato,Votos,Porcentaje");

                    foreach (DataGridViewRow fila in DGVResultados.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            archivo.WriteLine(
                                $"{fila.Cells["ColConvocatoria"].Value}," +
                                $"{fila.Cells["ColCandidato"].Value}," +
                                $"{fila.Cells["ColVotos"].Value}," +
                                $"{fila.Cells["ColPorcentaje"].Value}"
                            );
                        }
                    }
                }

                MessageBox.Show(
                    "Los resultados fueron exportados correctamente.",
                    "Exportación completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}