using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insightflow_users_service.Src.DTOs;

namespace insightflow_users_service.Src.Interfaces
{
    public interface IUserService
    {
        ResponseUserDto Create(CreateUserDto dto);
        IEnumerable<ResponseUserDto> GetAll();
        ResponseUserDto GetById(Guid id);
        void Update(Guid id, EditUserDto dto);
        void Delete(Guid id);
    }
}