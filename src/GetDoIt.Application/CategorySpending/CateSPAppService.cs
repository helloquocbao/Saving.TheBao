using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.UI;
using GetDoIt.CategorySpending.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDoIt.CategorySpending
{
    public class CateSPAppService : AsyncCrudAppService<Entities.CategorySpending, CategorySPOutputDto, int, PagedCateSPResultRequestDto, CategorySPInputDto, CategorySPUpdateDto>, ICateSPAppService
    {
        
        public CateSPAppService(IRepository<Entities.CategorySpending, int> repository) : base(repository)
        {
        }

        public override async Task<CategorySPOutputDto> CreateAsync(CategorySPInputDto input)
        {
            var category = ObjectMapper.Map<Entities.CategorySpending>(input);
            category.IsActive = true;
            
            return ObjectMapper.Map<CategorySPOutputDto>(await Repository.InsertAsync(category));
        }
        
        public async Task InActiveAsync(int id)
        {         
            var category = await Repository.GetAsync(id);
            if (category == null)
                throw new UserFriendlyException(L("CategorySpendingNotExist"));
            category.IsActive = false;
            await Repository.UpdateAsync(category);
        }
        public async Task IsActiveAsync(int id)
        {
            var category = await Repository.GetAsync(id);           
            if (category == null)
            {
                throw new UserFriendlyException(L("CategorySpendingNotExist"));                
            }
            category.IsActive = true;
            await Repository.UpdateAsync(category);

        }
    }
}
