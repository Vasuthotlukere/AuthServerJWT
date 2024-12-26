namespace AccessManagement.API.Models
{
    public class LoginRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyId { get; set; }
        public string ApplicationId { get; set; }
    }
}
