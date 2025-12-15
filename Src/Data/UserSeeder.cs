using insightflow_users_service.Src.Interfaces;
using insightflow_users_service.Src.Models;

namespace insightflow_users_service.Src.Data
{
    public static class UserSeeder
    {
        public static void Seed(IUserRepository repository)
        {
            // Evita duplicar datos en reinicios internos
            if (repository.GetAll().Any())
                return; 

            var users = new List<User>
            {
                new()
                {
                    FullName = "Juan Pérez",
                    Email = "juan.perez@insightflow.com",
                    Username = "juanp",
                    BirthDate = new DateTime(1990, 5, 12),
                    Address = "Av. Providencia 123",
                    Phone = "+56911111111",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "María González",
                    Email = "maria.gonzalez@insightflow.com",
                    Username = "mariag",
                    BirthDate = new DateTime(1988, 8, 23),
                    Address = "Los Leones 456",
                    Phone = "+56922222222",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Pedro Rojas",
                    Email = "pedro.rojas@insightflow.com",
                    Username = "pedror",
                    BirthDate = new DateTime(1995, 1, 3),
                    Address = "Irarrázaval 789",
                    Phone = "+56933333333",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Camila Soto",
                    Email = "camila.soto@insightflow.com",
                    Username = "camilas",
                    BirthDate = new DateTime(1992, 3, 14),
                    Address = "Macul 1000",
                    Phone = "+56944444444",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Diego Fuentes",
                    Email = "diego.fuentes@insightflow.com",
                    Username = "diegof",
                    BirthDate = new DateTime(1987, 6, 30),
                    Address = "Ñuñoa 321",
                    Phone = "+56955555555",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Valentina Morales",
                    Email = "valentina.morales@insightflow.com",
                    Username = "valem",
                    BirthDate = new DateTime(1998, 11, 9),
                    Address = "La Reina 777",
                    Phone = "+56966666666",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Sebastián Herrera",
                    Email = "sebastian.herrera@insightflow.com",
                    Username = "sebah",
                    BirthDate = new DateTime(1991, 9, 17),
                    Address = "Vitacura 888",
                    Phone = "+56977777777",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Fernanda López",
                    Email = "fernanda.lopez@insightflow.com",
                    Username = "ferl",
                    BirthDate = new DateTime(1994, 2, 25),
                    Address = "Las Condes 654",
                    Phone = "+56988888888",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Andrés Muñoz",
                    Email = "andres.munoz@insightflow.com",
                    Username = "andresm",
                    BirthDate = new DateTime(1989, 7, 1),
                    Address = "Peñalolén 432",
                    Phone = "+56999999999",
                    Password = "Password123",
                    Status = true
                },
                new()
                {
                    FullName = "Natalia Vega",
                    Email = "natalia.vega@insightflow.com",
                    Username = "natv",
                    BirthDate = new DateTime(1996, 12, 5),
                    Address = "Maipú 987",
                    Phone = "+56910101010",
                    Password = "Password123",
                    Status = true
                }
            };

            foreach (var user in users)
            {
                repository.Add(user);
            }
        }
    }
}
