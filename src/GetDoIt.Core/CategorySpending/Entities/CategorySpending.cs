using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetDoIt.CategorySpending.Entities
{
    [Table("CategorySpending")]
    public class CategorySpending: FullAuditedEntity<int>
    {
        public const int MaxDesLength = 500;

        [Required]
        public string Name { get; set; }

        [MaxLength(MaxDesLength)]
        public string Description { get; set; }
        
        public bool IsActive { get; set; }


    }
}
