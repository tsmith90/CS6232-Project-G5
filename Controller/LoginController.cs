using ClinicSupport.DAL;
using ClinicSupport.Model;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the Login table of the ClinicSupport DB
    /// </summary>
    class LoginController
    {
        private readonly LoginDAL loginDBDAL;

        /// <summary>
        /// 0-parameter constructor for the LoginController class
        /// </summary>
        public LoginController()
        {
            loginDBDAL = new LoginDAL();
        }

        /// <summary>
        /// Method to get the login information from the LoginDBDAL
        /// </summary>
        /// <param user = "user">the user's given username</param> 
        /// <param password = "password">the users password</param> 
        /// <returns>A new User with a username and privileges</returns>
        public User GetLoginInformation(string user, string password)
        {
            if (user == null || password == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            string hashedPassword = HashPassword(user, password);

            User information = loginDBDAL.GetLoginInformation(user, hashedPassword);

            return information;
        }

        /// <summary>
        /// Method to create a hashed password
        /// </summary>
        /// <param user = "user">the user's given username</param> 
        /// <param password = "password">the users plain-text password</param> 
        /// <returns>A string with a hash to be stored as a password</returns>
        private string HashPassword(string user, string password)
        {
            
            byte[] salt = new byte[31/8];

            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                            password: user + password,
                            salt: salt,
                            prf: KeyDerivationPrf.HMACSHA256,
                            iterationCount: 10000,
                            numBytesRequested: 256 / 8));

            return hashed;
        }
    }
}
