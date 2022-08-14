using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.StatusSpending.Entities
{
    [Table("StatusSpending")]
    public class StatusSpending : CreationAuditedEntity<int>
    {
        public string CODE { get; set; }
        public string ColorCode { get; set; }

        public string BorderColorCode { get; set; }

        public bool IsActive { get; set; }
       
    }
}
