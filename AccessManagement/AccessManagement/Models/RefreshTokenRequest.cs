namespace AccessManagement.API.Models
{
    public class RefreshTokenRequest
    {
        public string UserName {  get; set; }
        public string CompanyId { get; set; }
        public string ApplicationId { get; set; }
        public string RefreshToken { get; set; }
    }
}
