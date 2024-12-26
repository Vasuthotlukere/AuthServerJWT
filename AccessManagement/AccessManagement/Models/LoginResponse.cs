namespace AccessManagement.API.Models
{
    public class LoginResponse
    {
        public string RequestId { get; set; }
        public string UserName {  get; set; }
        public string Token { get; set; }
        public string CompanyId { get; set; }
        public string ApplicationId {  get; set; }
        public DateTime CreatedOn { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
    }
}
