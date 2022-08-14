using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace GetDoIt.CategorySpending.Dto
{
    public class PagedCateSPResultRequestDto: PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}