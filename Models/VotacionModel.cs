namespace Certamen.Models
{
    public class Voto
    {
        public int VotoId { get; set; }
        public string ConcursanteId { get; set; }
        public int UserId { get; set; }
    }

    public class Concursante
    {
        public int ConcursanteId { get; set; }
        public string Concursantes { get; set; }
        public int Votos { get; set; }
    }

}

