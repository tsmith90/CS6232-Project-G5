using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace ClinicSupport.Controller
{
    /// <summary>
    /// Class to interact with the Login table of the ClinicSupport DB
    /// </summary>
    class LoginController
    {

        /// <summary>
        /// 0-parameter constructor for the LoginController class
        /// </summary>
        public LoginController()
        {

        }

        /// <summary>
        /// Method to get the login information from the ClinicSupport DB
        /// </summary>
        /// <param user = "user">the user's given username</param> 
        /// <param password = "password">the users plain-text password</param> 
        /// <returns>A string with the privileges of the user</returns>
        public String GetLoginInformation(string user, string password)
        {
            if (user == null || password == null)
            {
                throw new ArgumentNullException("Please enter valid credentials");
            }

            string hashedPassword = HashPassword(user, password);

            //put the DBDAL here and check it against the DB then return what it says
            //loginDBDAL.GetLoginInformation(user, hashedPassword);

            return hashedPassword;
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
