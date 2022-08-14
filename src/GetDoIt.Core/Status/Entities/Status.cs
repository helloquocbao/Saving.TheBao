using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetDoIt.Status.Entities
{
    [Table("Status")]
    public class Status: CreationAuditedEntity<int>
    {
        public string CODE { get; set; }
        public string ColorCode { get; set; }    

        public string BorderColorCode { get; set; }
        public bool IsActive { get; set; }
    }
}
