using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.Status.Dto
{
    public class StatusInputDto
    {
        public string CODE { get; set; }
        public string ColorCode { get; set; }
        public string BorderColorCode { get; set; }


    }
}
