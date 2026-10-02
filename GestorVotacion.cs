namespace Miniproyecto1
{
    internal static class GestorVotacion
    {
        // Almacena los votos registrados durante la ejecución del programa.
        private static List<Voto> votos = new List<Voto>();

        // Permite consultar los votos registrados.
        public static List<Voto> ObtenerVotos()
        {
            return votos;
        }

        // Registra un nuevo voto.
        public static void RegistrarVoto(Voto voto)
        {
            votos.Add(voto);
        }

        // Verifica si un alumno ya votó en una convocatoria determinada.
        public static bool YaVoto(string idAlumno, string convocatoria)
        {
            foreach (Voto voto in votos)
            {
                if (voto.IdAlumno == idAlumno &&
                    voto.Convocatoria == convocatoria)
                {
                    return true;
                }
            }

            return false;
        }

        // Obtiene la cantidad total de votos registrados.
        public static int ObtenerTotalVotos()
        {
            return votos.Count;
        }
    }
}