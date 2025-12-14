using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insightflow_users_service.Src.Interfaces;
using insightflow_users_service.Src.Models;

namespace insightflow_users_service.Src.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static readonly ConcurrentDictionary<Guid, User> _users = new();

        public IEnumerable<User> GetAll() => _users.Values;

        public User? GetById(Guid id)
            => _users.TryGetValue(id, out var user) ? user : null;

        public User? GetByEmail(string email)
            => _users.Values.FirstOrDefault(u => u.Email == email);

        public User? GetByUsername(string username)
            => _users.Values.FirstOrDefault(u => u.Username == username);

        public void Add(User user) => _users[user.Id] = user;

        public void Update(User user) => _users[user.Id] = user;

        public void SoftDelete(Guid id)
        {
            if (_users.TryGetValue(id, out var user))
            {
                user.Status = false;
                _users[id] = user;
            }
        }
    }
}