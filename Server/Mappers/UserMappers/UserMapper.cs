using TIN_Project.Server.Enums;
using TIN_Project.Server.Models;
using TIN_Project.Shared.DTOs.UserDTOs;

namespace TIN_Project.Server.Mappers.UserMappers
{
    public class UserMapper : IUserMapper
    {
        public User MapRegisterUserDTOToUser(RegisterUserDTO userDTO, Role role)
        {
            return new User
            {
                Name = userDTO.Name,
                Surname = userDTO.Surname,
                Username = userDTO.Username,
                Email = userDTO.Email,
                Password = userDTO.Password,
                BirthDate = DateOnly.FromDateTime((DateTime)userDTO.BirthDate),
                Role = role
            };
        }

        public GetUserDTO MapUserToGetUserDTO(User user)
        {
            return new GetUserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Email = user.Email,
                BirthDate = user.BirthDate,
                IsAdmin = user.Role == Role.Admin
            };
        }

        public List<GetUserDTO> MapUsersToGetUserDTOs(List<User> users)
        {
            return users.Select(user => MapUserToGetUserDTO(user)).ToList();
        }

        public User MapAddAdminDTOToUser(AddAdminDTO addAdminDTO, Role role)
        {
            return new User
            {
                Username = addAdminDTO.Username,
                Password = addAdminDTO.Password,
                Email = addAdminDTO.Email,
                Name = addAdminDTO.Name,
                Surname = addAdminDTO.Surname,
                BirthDate = DateOnly.FromDateTime((DateTime)addAdminDTO.BirthDate),
                Role = role
            };
        }

        public GetUpdateUserProfileDTO MapUserToGetUpdateUserProfileDTO(User user)
        {
            return new GetUpdateUserProfileDTO
            {
				IdUser = user.IdUser,
				Username = user.Username,
				Name = user.Name,
				Surname = user.Surname,
				Email = user.Email,
				BirthDate = user.BirthDate.ToDateTime(TimeOnly.Parse("0:00")),
            };

        }
	}
}
