using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        internal static string AccessTokenCreated = "Access token created.";
        internal static string UserAllreadyExists = "User allready exists.";
        internal static string UserRegistered = "Register successful.";
        internal static string UserNotFound = "User not found.";
        internal static string PasswordError = "Password is incorrect";
        internal static string LoginSuccessful = "Login successful";
       
        internal static string AuthorizationDenied;
        internal static string ProductAdded;
        internal static string ProductDeleted;
        internal static string ProductNameAllreadyExists;
    }
}
