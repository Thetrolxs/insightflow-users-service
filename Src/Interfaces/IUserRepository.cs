using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insightflow_users_service.Src.Models;

namespace insightflow_users_service.Src.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(Guid id);
        User? GetByEmail(string email);
        User? GetByUsername(string username);
        void Add(User user);
        void Update(User user);
        void SoftDelete(Guid id);        
    }
}