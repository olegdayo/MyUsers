using System;
using System.Collections.Generic;
using System.Text;

namespace MyUsers
{
    /// <summary>
    /// The owner of shop class.
    /// </summary>
    static class Admin
    {
        // Admin username and password hash.
        public static string Username { get; private set; } = "username";
        public static int Password { get; private set; } = "password".GetHashCode();
    }
}
