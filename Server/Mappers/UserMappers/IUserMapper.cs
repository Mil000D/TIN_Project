using TIN_Project.Server.Models;
using TIN_Project.Server.Enums;
using TIN_Project.Shared.DTOs.UserDTOs;
namespace TIN_Project.Server.Mappers.UserMappers
{
    public interface IUserMapper
    {
        public User MapRegisterUserDTOToUser(RegisterUserDTO userDTO, Role role);
        public GetUserDTO MapUserToGetUserDTO(User user);
        public List<GetUserDTO> MapUsersToGetUserDTOs(List<User> users);
        public User MapAddAdminDTOToUser(AddAdminDTO addAdminDTO, Role role);
        public GetUpdateUserProfileDTO MapUserToGetUpdateUserProfileDTO(User user);

	}
}
