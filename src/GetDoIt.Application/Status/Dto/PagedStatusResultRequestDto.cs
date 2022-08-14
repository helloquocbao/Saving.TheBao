using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace GetDoIt.Status.Dto
{
    public class PagedStatusResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}