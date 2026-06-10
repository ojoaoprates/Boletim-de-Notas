namespace BoletimNotas.Models
{
    public class BoletimItem
    {
        public int Id { get; set; }
        public string Materia { get; set; }
        public decimal Nota { get; set; }
        public string Professor { get; set; }
        public string Observacao { get; set; }
    }
}