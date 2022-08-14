using Abp.Application.Services;
using Abp.Domain.Repositories;
using GetDoIt.Status.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.Status
{ 
    public class StatusAppService : AsyncCrudAppService<Entities.Status, StatusOutputDto, int, PagedStatusResultRequestDto, StatusInputDto, StatusUpdateDto>, IStatusAppService
    {
        public StatusAppService(IRepository<Entities.Status> repository) : base(repository)
        {
        }
        public override async Task<StatusOutputDto> CreateAsync(StatusInputDto input)
        {
            var statusSpending = ObjectMapper.Map<Entities.Status>(input);
            //statusSpending.IsActive = true;

            return ObjectMapper.Map<StatusOutputDto>(await Repository.InsertAsync(statusSpending));
        }
    }
}
