﻿using Entities;

namespace Core.UserInterfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<User> GetUserByUsernameAsync(string username);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task RegisterUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int userId);

        // Özel İşlemler
        Task<User> GetUserByEmailAsync(string email);
        Task<User> ValidateUserAsync(string username, string password);
    }
}
