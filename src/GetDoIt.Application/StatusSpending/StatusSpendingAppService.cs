using Abp.Application.Services;
using Abp.Domain.Repositories;
using GetDoIt.StatusSpending.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.StatusSpending
{
    public class StatusSpendingAppService : AsyncCrudAppService<Entities.StatusSpending, StatusSPOutputDto, int, PagedStatusSPResultRequestDto, StatusSPInputDto, StatusSPUpdateDto>, IStatusSpendingAppService
    {
        public StatusSpendingAppService(IRepository<Entities.StatusSpending> repository) : base(repository)
        {
        }
        public override async Task<StatusSPOutputDto> CreateAsync(StatusSPInputDto input)
        {
            var statusSpending = ObjectMapper.Map<Entities.StatusSpending>(input);
            statusSpending.IsActive = true;

            return ObjectMapper.Map<StatusSPOutputDto>(await Repository.InsertAsync(statusSpending));
        }
    }
}
