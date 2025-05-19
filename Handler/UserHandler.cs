using FinalProject_PSD_EmpatSekawan.Model;
using FinalProject_PSD_EmpatSekawan.Repository;

namespace FinalProject_PSD_EmpatSekawan.Handler
{
    public class UserHandler
    {
        private UserRepository userRepository = new UserRepository();

        public bool RegisterUser(MsUser user)
        {
            return userRepository.RegisterUser(user);
        }

        public MsUser LoginUser(string email, string password)
        {
            MsUser user = userRepository.GetUserByEmail(email);
            if (user != null && user.UserPassword == password)
            {
                return user;
            }
            return null;
        }
    }
}
