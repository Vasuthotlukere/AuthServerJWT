using System;
using AccessManagement.API.Models;

namespace AccessManagement.API.Models
{
    public class AppSettings
    {
        public string AuthApiUrl { get; set; }
        public Uri ApiUri { get; set; }
        public int HttpClientTimeoutInSeconds { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
        public JwtSettings JwtSettings { get; set; }
        public string AllowedOrigins { get; set; }
    }
}

