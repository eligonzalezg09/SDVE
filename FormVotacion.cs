using System;
using System.Windows.Forms;

namespace Miniproyecto1
{
    public partial class FormVotacion : Form
    {
        // Datos del alumno.
        private string idAlumno;
        private string nombreAlumno;
        private string grupoAlumno;
        private string carreraAlumno;
        private string centroAlumno;

        // Convocatorias seleccionadas.
        private bool sociedadSeleccionada;
        private bool consejoSeleccionado;
        private bool representantesSeleccionado;

        public FormVotacion(
            string id,
            string nombre,
            string grupo,
            string carrera,
            string centro,
            bool sociedad,
            bool consejo,
            bool representantes)
        {
            InitializeComponent();

            idAlumno = id;
            nombreAlumno = nombre;
            grupoAlumno = grupo;
            carreraAlumno = carrera;
            centroAlumno = centro;

            sociedadSeleccionada = sociedad;
            consejoSeleccionado = consejo;
            representantesSeleccionado = representantes;

            // Muestra únicamente las convocatorias seleccionadas.
            PSociedad.Visible = sociedadSeleccionada;
            PConsejoUniversitario.Visible = consejoSeleccionado;
            PRepresentantes.Visible = representantesSeleccionado;
        }

        private void BRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BConfirmar_Click(object sender, EventArgs e)
        {
            // Valida la votación para Sociedad de Alumnos.
            if (sociedadSeleccionada)
            {
                if (!RBSociedad1.Checked &&
                    !RBSociedad2.Checked &&
                    !RBSociedad3.Checked &&
                    !RBSociedadOtro.Checked)
                {
                    MessageBox.Show(
                        "Seleccione un candidato para Sociedad de Alumnos.",
                        "Votación incompleta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (RBSociedadOtro.Checked &&
                    string.IsNullOrWhiteSpace(TBSociedadOtro.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del candidato no registrado para Sociedad de Alumnos.",
                        "Candidato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    TBSociedadOtro.Focus();
                    return;
                }

                if (GestorVotacion.YaVoto(idAlumno, "Sociedad de Alumnos"))
                {
                    MessageBox.Show(
                        "Este alumno ya registró un voto para Sociedad de Alumnos.",
                        "Voto duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Valida la votación para Consejo Universitario.
            if (consejoSeleccionado)
            {
                if (!RBConsejo1.Checked &&
                    !RBConsejo2.Checked &&
                    !RBConsejo3.Checked &&
                    !RBConsejoOtro.Checked)
                {
                    MessageBox.Show(
                        "Seleccione un candidato para Consejo Universitario.",
                        "Votación incompleta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (RBConsejoOtro.Checked &&
                    string.IsNullOrWhiteSpace(TBConsejoOtro.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del candidato no registrado para Consejo Universitario.",
                        "Candidato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    TBConsejoOtro.Focus();
                    return;
                }

                if (GestorVotacion.YaVoto(idAlumno, "Consejo Universitario"))
                {
                    MessageBox.Show(
                        "Este alumno ya registró un voto para Consejo Universitario.",
                        "Voto duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Valida la votación para Consejo de Representantes.
            if (representantesSeleccionado)
            {
                if (!RBRepresentante1.Checked &&
                    !RBRepresentante2.Checked &&
                    !RBRepresentante3.Checked &&
                    !RBRepresentanteOtro.Checked)
                {
                    MessageBox.Show(
                        "Seleccione un candidato para Consejo de Representantes.",
                        "Votación incompleta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (RBRepresentanteOtro.Checked &&
                    string.IsNullOrWhiteSpace(TBRepresentanteOtro.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del candidato no registrado para Consejo de Representantes.",
                        "Candidato requerido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    TBRepresentanteOtro.Focus();
                    return;
                }

                if (GestorVotacion.YaVoto(idAlumno, "Consejo de Representantes"))
                {
                    MessageBox.Show(
                        "Este alumno ya registró un voto para Consejo de Representantes.",
                        "Voto duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // Registra el voto de Sociedad de Alumnos.
            if (sociedadSeleccionada)
            {
                string candidatoSociedad = "";

                if (RBSociedad1.Checked)
                    candidatoSociedad = "Ana Torres";
                else if (RBSociedad2.Checked)
                    candidatoSociedad = "Luis Herrera";
                else if (RBSociedad3.Checked)
                    candidatoSociedad = "Mariana Lopez";
                else if (RBSociedadOtro.Checked)
                    candidatoSociedad = TBSociedadOtro.Text.Trim();

                Voto votoSociedad = new Voto(
                    idAlumno,
                    nombreAlumno,
                    grupoAlumno,
                    carreraAlumno,
                    centroAlumno,
                    "Sociedad de Alumnos",
                    candidatoSociedad);

                GestorVotacion.RegistrarVoto(votoSociedad);
            }

            // Registra el voto de Consejo Universitario.
            if (consejoSeleccionado)
            {
                string candidatoConsejo = "";

                if (RBConsejo1.Checked)
                    candidatoConsejo = "Carlos Mendez";
                else if (RBConsejo2.Checked)
                    candidatoConsejo = "Valeria Sanchez";
                else if (RBConsejo3.Checked)
                    candidatoConsejo = "Jorge Ramirez";
                else if (RBConsejoOtro.Checked)
                    candidatoConsejo = TBConsejoOtro.Text.Trim();

                Voto votoConsejo = new Voto(
                    idAlumno,
                    nombreAlumno,
                    grupoAlumno,
                    carreraAlumno,
                    centroAlumno,
                    "Consejo Universitario",
                    candidatoConsejo);

                GestorVotacion.RegistrarVoto(votoConsejo);
            }

            // Registra el voto de Consejo de Representantes.
            if (representantesSeleccionado)
            {
                string candidatoRepresentante = "";

                if (RBRepresentante1.Checked)
                    candidatoRepresentante = "Sofia Ruiz";
                else if (RBRepresentante2.Checked)
                    candidatoRepresentante = "Diego Morales";
                else if (RBRepresentante3.Checked)
                    candidatoRepresentante = "Fernanda Castro";
                else if (RBRepresentanteOtro.Checked)
                    candidatoRepresentante = TBRepresentanteOtro.Text.Trim();

                Voto votoRepresentante = new Voto(
                    idAlumno,
                    nombreAlumno,
                    grupoAlumno,
                    carreraAlumno,
                    centroAlumno,
                    "Consejo de Representantes",
                    candidatoRepresentante);

                GestorVotacion.RegistrarVoto(votoRepresentante);
            }

            MessageBox.Show(
                "El voto fue registrado correctamente.",
                "Votación completada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void RBSociedad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton seleccionado = (RadioButton)sender;

            if (seleccionado.Checked)
            {
                if (seleccionado != RBSociedad1)
                    RBSociedad1.Checked = false;

                if (seleccionado != RBSociedad2)
                    RBSociedad2.Checked = false;

                if (seleccionado != RBSociedad3)
                    RBSociedad3.Checked = false;

                if (seleccionado != RBSociedadOtro)
                    RBSociedadOtro.Checked = false;
            }
        }

        private void RBConsejo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton seleccionado = (RadioButton)sender;

            if (seleccionado.Checked)
            {
                if (seleccionado != RBConsejo1)
                    RBConsejo1.Checked = false;

                if (seleccionado != RBConsejo2)
                    RBConsejo2.Checked = false;

                if (seleccionado != RBConsejo3)
                    RBConsejo3.Checked = false;

                if (seleccionado != RBConsejoOtro)
                    RBConsejoOtro.Checked = false;
            }
        }

        private void RBRepresentante_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton seleccionado = (RadioButton)sender;

            if (seleccionado.Checked)
            {
                if (seleccionado != RBRepresentante1)
                    RBRepresentante1.Checked = false;

                if (seleccionado != RBRepresentante2)
                    RBRepresentante2.Checked = false;

                if (seleccionado != RBRepresentante3)
                    RBRepresentante3.Checked = false;

                if (seleccionado != RBRepresentanteOtro)
                    RBRepresentanteOtro.Checked = false;
            }
        }
    }
}