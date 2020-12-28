using _10Class_exercise03_Logger.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace _10Class_exercise03_Logger.Exceptions
{
    public class InvalidUserException : Exception
    {
        private LoggerService _loggerService = new LoggerService();
        public InvalidUserException() : base("Unknown or invalid user") 
        {
            _loggerService.Log("Invalid user", "Unknown user tried to log in");
        }

        public InvalidUserException(string message) : base(message)
        {
            _loggerService.Log("Invalid user", message);
        }
    }



}
