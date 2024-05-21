using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bh_server_app.DTOs;

namespace bh_server_app.Services.Interface
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(int id);
        Task<IEnumerable<UserDTO>> GetAllUsers();
        Task<UserDTO> CreateUser(UserDTO userDTO);
        Task<UserDTO> UpdateUser(int id, UserDTO userDTO);
        Task DeleteUser(int id);
    }
}