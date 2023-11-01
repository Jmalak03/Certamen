namespace Certamen.Models
{
    public class Participantes
    {
        public int Idmodelo { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Edad {  get; set; }

        public DateOnly FechaNac {  get; set; }

        public DateTime Fecha { get; set; }

        public int Altura { get; set; }

        public int Peso { get; set;}

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Nacionalidad {  get; set; }

        public string FormacionAcademica { get; set; }


    }
}
