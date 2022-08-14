using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace GetDoIt.StatusSpending.Dto
{
    public class PagedStatusSPResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}