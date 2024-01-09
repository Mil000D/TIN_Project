using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.OrderDTOs;

namespace TIN_Project.Server.Mappers.OrderMappers
{
    public class OrderMapper : IOrderMapper
    {
        public Order MapAddOrderDTOToOrder(AddOrderDTO addOrderDTO, int idUser)
        {
            return new Order
            {
                IdUser = idUser,
                IdMovieRepertoire = addOrderDTO.IdMovieRepertoire,
                IsPaid = addOrderDTO.IsPaid
            };
        }
        public List<GetOrderDTO> MapToGetOrderDTOs(List<Order> orders, List<Movie> movies, List<MovieRepertoire> movieRepertoires, List<Cinema> cinemas, List<Repertoire> repertoires)
        {
            List<GetOrderDTO> getOrderDTOs = new List<GetOrderDTO>();
            foreach (Order order in orders)
            {
                MovieRepertoire movieRepertoire = movieRepertoires.FirstOrDefault(mr => mr.IdMovieRepertoire == order.IdMovieRepertoire);
                Movie movie = movies.FirstOrDefault(m => m.IdMovie == movieRepertoire.IdMovie);
                Repertoire repertoire = repertoires.FirstOrDefault(r => r.IdRepertoire == movieRepertoire.IdRepertoire);
                Cinema cinema = cinemas.FirstOrDefault(c => c.IdCinema == repertoire.IdCinema);
                getOrderDTOs.Add(new GetOrderDTO
                {
                    IdMovieRepertoire = order.IdMovieRepertoire,
                    MoviePosterUrl = movie.PosterUrl,
                    MovieTitle = movie.Title,
                    CinemaName = cinema.Name,
                    CinemaAddress = cinema.Address,
                    ShowDate = repertoire.Date,
                    ShowTime = movieRepertoire.ShowTime,
                    IsPaid = order.IsPaid
                });;
            }
            return getOrderDTOs;
        }
    }
}
