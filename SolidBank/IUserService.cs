using System;
namespace SolidBank
{
    public interface IUserService
    {
        User GetUserInformation(int userId);
    }

    public class UserService : IUserService
    {
        public User GetUserInformation(int userId)
        {
            return new User { Name = "Andres", LastName = "Pineda", Type = "Regular" };
        }
    }
}
