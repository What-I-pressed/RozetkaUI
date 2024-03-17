﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Constants
{
    public static class Roles
    {
        public static List<string> All = new List<string>
        {
            Admin,
            User,
            SuperAdmin
        };
        public const string SuperAdmin = "SuperAdmin";
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
