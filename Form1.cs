namespace Miniproyecto1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

            CBGrupo.SelectedIndex = -1;
            CBCarrera.SelectedIndex = -1;
            CBCentro.SelectedIndex = -1;
        }

        private void BLimpiar_Click(object sender, EventArgs e)
        {
            TBID.Clear();
            TBNombre.Clear();

            CBGrupo.SelectedIndex = -1;
            CBCarrera.SelectedIndex = -1;
            CBCentro.SelectedIndex = -1;

            CHSociedad.Checked = false;
            CHConsejoUniversitario.Checked = false;
            CHRepresentantes.Checked = false;

            TBID.Focus();
        }

        private void BContinuar_Click(object sender, EventArgs e)
        {
            // Valida que se hayan capturado los datos del alumno.
            if (string.IsNullOrWhiteSpace(TBID.Text))
            {
                MessageBox.Show(
                    "Ingrese el ID del alumno.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TBID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(TBNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del alumno.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TBNombre.Focus();
                return;
            }

            if (CBGrupo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un grupo.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBGrupo.Focus();
                return;
            }

            if (CBCarrera.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione una carrera.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBCarrera.Focus();
                return;
            }

            if (CBCentro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un centro universitario.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CBCentro.Focus();
                return;
            }

            // Valida que se seleccione al menos una convocatoria.
            if (!CHSociedad.Checked &&
                !CHConsejoUniversitario.Checked &&
                !CHRepresentantes.Checked)
            {
                MessageBox.Show(
                    "Seleccione al menos una convocatoria para votar.",
                    "Convocatoria requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Abre la papeleta de votación.
            FormVotacion votacion = new FormVotacion(
     TBID.Text.Trim(),
     TBNombre.Text.Trim(),
     CBGrupo.Text,
     CBCarrera.Text,
     CBCentro.Text,
     CHSociedad.Checked,
     CHConsejoUniversitario.Checked,
     CHRepresentantes.Checked
 );

            this.Hide();
            votacion.ShowDialog();
            this.Show();
        }

        private void BResultados_Click(object sender, EventArgs e)
        {
            FormResultados resultados = new FormResultados();

            this.Hide();
            resultados.ShowDialog();
            this.Show();
        }
    }
}