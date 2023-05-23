﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kausar.Model
{
    internal class API
    {
        public const string BaseUrl = "https://localhost:7277";
        public const string AuthenticateUser = "/api/Users/AuthenticateUser";
        public const string RegisterUser = "/api/Users/RegisterUser";
        public const string RefreshToken = "/api/Users/RefreshToken";
        public const string GetAllStudents = "/api/Students/GetAllStudent";
    }
}
