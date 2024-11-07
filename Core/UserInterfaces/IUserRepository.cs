﻿using Entities;

namespace Core.UserInterfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int userId);
        Task<User> GetByUsernameAsync(string username);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int userId);

        // Özel İşlemler
        Task<User> GetByEmailAsync(string email);
        Task<User> ValidateUserCredentialsAsync(string username, string password);
    }
}