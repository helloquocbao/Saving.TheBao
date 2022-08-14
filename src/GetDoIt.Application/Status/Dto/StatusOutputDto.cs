using Abp.Application.Services.Dto;
using System;

namespace GetDoIt.Status.Dto
{
    public class StatusOutputDto : EntityDto<int>
    {
        public string CODE { get; set; }
        public string ColorCode { get; set; }

        public string BorderColorCode { get; set; }

        public bool IsActive { get; set; }

    }
}