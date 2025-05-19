using FinalProject_PSD_EmpatSekawan.Handler;
using FinalProject_PSD_EmpatSekawan.Model;
using System;

namespace FinalProject_PSD_EmpatSekawan.Controller
{
    public class UserController
    {
        private UserHandler userHandler = new UserHandler();

        public bool RegisterUser(string username, string email, string password, string gender, DateTime dob)
        {
            return userHandler.RegisterUser(new MsUser()
            {
                UserName = username,
                UserEmail = email,
                UserPassword = password,
                UserGender = gender,
                UserDOB = dob
            });
        }
    }
}
