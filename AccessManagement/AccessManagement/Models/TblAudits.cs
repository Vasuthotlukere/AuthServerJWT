using System.ComponentModel.DataAnnotations;

namespace AccessManagement.API.Models
{
    public class TblAudits
    {
        [Key]
        public int AuditId { get; set; }
        public string AuditEntity { get; set; }
        public string AuditAction {  get; set; }
        public DateTime AuditDateTime { get; set; }
        public string AuditUserId { get; set; }
        public string AuditUserName { get; set; }
        public string AuditDescription { get; set; }
    }
}
