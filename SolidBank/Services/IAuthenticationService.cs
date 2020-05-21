namespace SolidBank.Services
{
    public interface IAuthenticationService
    {
        bool SignIn(string username, string password);

        bool SignUp(string name, string username, string password);

        void ForgotPassword(string email);

        void UnlockUser(int userId);
    }
}