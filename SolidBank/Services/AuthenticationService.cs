using System;
namespace SolidBank.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {

        }

        public bool SignIn(string username, string password)
        {
            return true;
        }

        public bool SignUp(string name, string username, string password)
        {
            return true;
        }

        public void ForgotPassword(string email)
        {

        }

        public void UnlockUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
