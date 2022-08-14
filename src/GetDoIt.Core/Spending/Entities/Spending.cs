using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.Spending.Entities
{
    [Table("Spending")]
    public class Spending : FullAuditedEntity<int>
    {
        public const int MaxDesLength = 500;

        [Required]
        [MaxLength(MaxDesLength)]
        public string Description { get; set; }

        [Required]
        public long Price { get; set; }

        [Required]
        public DateTime SpendingDate { get; set; }

        public int IdUser { get; set; }

        public int IdCateSpending { get; set; }

        public int IdStatusSpending { get; set; }

        public bool IsActive { get; set; }

    }
}
