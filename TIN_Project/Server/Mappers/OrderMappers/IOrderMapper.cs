using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.OrderDTOs;

namespace TIN_Project.Server.Mappers.OrderMappers
{
    public interface IOrderMapper
    {
        public Order MapAddOrderDTOToOrder(AddOrderDTO addOrderDTO, int idUser);
        public List<GetOrderDTO> MapToGetOrderDTOs(List<Order> orders, List<Movie> movies, List<MovieRepertoire> movieRepertoires, List<Cinema> cinemas, List<Repertoire> repertoires);
    }
}
