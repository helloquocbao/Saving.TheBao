using Abp.Application.Services.Dto;
using System;

namespace GetDoIt.CategorySpending.Dto
{
    public class CategorySPOutputDto : EntityDto<int>
    {       
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get;set; }

    }
}