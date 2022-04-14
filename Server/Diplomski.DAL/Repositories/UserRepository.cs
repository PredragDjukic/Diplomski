﻿using Diplomski.DAL.Entities;
using Diplomski.DAL.Interfaces;

namespace Diplomski.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ConcurrencyDbContext _context;


        public UserRepository(ConcurrencyDbContext context)
        {
            _context = context;
        }


        public void Register(User entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.UpdatedAt = DateTime.UtcNow;

            _context.User.Add(entity);
        }
    }
}