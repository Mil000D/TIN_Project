namespace TIN_Project.Server.Models
{
    public class Cinema
    {
        public int IdCinema { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Repertoire> Repertoires { get; set; }
    }
}
