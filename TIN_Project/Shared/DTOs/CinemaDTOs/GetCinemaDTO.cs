using TIN_Project.Shared.DTOs.GenreDTOs;

namespace TIN_Project.Shared.DTOs.CinemaDTOs
{
    public class GetCinemaDTO
    {
        public int IdCinema { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override bool Equals(object o)
        {
            var other = o as GetCinemaDTO;
            return other?.IdCinema == IdCinema;
        }

        public override int GetHashCode() => IdCinema.GetHashCode();
    }
}
