using TIN_Project.Shared.DTOs.MovieDTOs;

namespace TIN_Project.Shared.DTOs.RepertoireDTOs
{
    public class GetRepertoireDTO
    {
        public int IdRepertoire { get; set; }
        public DateTime Date { get; set; }
        public override bool Equals(object o)
        {
            var other = o as GetRepertoireDTO;
            return other?.IdRepertoire == IdRepertoire;
        }
        public override int GetHashCode() => IdRepertoire.GetHashCode();
    }
}
