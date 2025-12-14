using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insightflow_users_service.Src.DTOs;
using insightflow_users_service.Src.Interfaces;
using insightflow_users_service.Src.Models;

namespace insightflow_users_service.Src.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        // Create
        public ResponseUserDto Create(CreateUserDto dto)
        {
            if (_repository.GetByEmail(dto.Email) != null)
                throw new InvalidOperationException("El correo ya está registrado.");

            if (_repository.GetByUsername(dto.Username) != null)
                throw new InvalidOperationException("El nombre de usuario ya está en uso.");

            var user = new User
            {
                FullName = dto.FullName,
                Email = dto.Email,
                Username = dto.Username,
                BirthDate = dto.birthday,
                Address = dto.Address,
                Phone = dto.Phone,
                Password = dto.Password,
                Status = true
            };

            _repository.Add(user);

            return MapToResponse(user);
        }

        // All
        public IEnumerable<ResponseUserDto> GetAll()
        {
            return _repository.GetAll()
                .Where(u => u.Status)
                .Select(MapToResponse);
        }

        // By ID
        public ResponseUserDto GetById(Guid id)
        {
            var user = _repository.GetById(id);

            if (user == null)
                throw new KeyNotFoundException("Usuario no encontrado.");

            return MapToResponse(user);
        }

        // Update
        public void Update(Guid id, EditUserDto dto)
        {
            var user = _repository.GetById(id);

            if (user == null)
                throw new KeyNotFoundException("Usuario no encontrado.");

            if (user.Username != dto.Username &&
                _repository.GetByUsername(dto.Username) != null)
            {
                throw new InvalidOperationException("El nombre de usuario ya está en uso.");
            }

            user.FullName = dto.FullName;
            user.Username = dto.Username;

            _repository.Update(user);
        }

        // Soft Delete
        public void Delete(Guid id)
        {
            var user = _repository.GetById(id);

            if (user == null)
                throw new KeyNotFoundException("Usuario no encontrado.");

            _repository.SoftDelete(id);
        }

        //Mapeo de responses
        private static ResponseUserDto MapToResponse(User user)
        {
            return new ResponseUserDto
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                Username = user.Username,
                Status = user.Status ? "Activo" : "Inactivo",
                Birthday = user.BirthDate,
                Address = user.Address
            };
        }
    }
}