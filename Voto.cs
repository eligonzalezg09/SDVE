namespace Miniproyecto1
{
    internal class Voto
    {
        public string IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public string Grupo { get; set; }
        public string Carrera { get; set; }
        public string CentroUniversitario { get; set; }
        public string Convocatoria { get; set; }
        public string Candidato { get; set; }

        public Voto(
            string idAlumno,
            string nombreAlumno,
            string grupo,
            string carrera,
            string centroUniversitario,
            string convocatoria,
            string candidato)
        {
            IdAlumno = idAlumno;
            NombreAlumno = nombreAlumno;
            Grupo = grupo;
            Carrera = carrera;
            CentroUniversitario = centroUniversitario;
            Convocatoria = convocatoria;
            Candidato = candidato;
        }
    }
}