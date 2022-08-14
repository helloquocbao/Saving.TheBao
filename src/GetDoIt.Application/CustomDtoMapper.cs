using AutoMapper;
using GetDoIt.CategorySpending.Dto;
using GetDoIt.Status.Dto;
using GetDoIt.StatusSpending.Dto;

namespace GetDoIt
{
    public static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            #region CategorySpending
            configuration.CreateMap<CategorySpending.Entities.CategorySpending, CategorySPOutputDto>();
            configuration.CreateMap<CategorySPInputDto, CategorySpending.Entities.CategorySpending > ();
            configuration.CreateMap<CategorySPUpdateDto, CategorySpending.Entities.CategorySpending>();
            #endregion

            #region StatusSpending
            configuration.CreateMap<StatusSpending.Entities.StatusSpending, StatusSPOutputDto>();
            configuration.CreateMap<StatusSPInputDto, StatusSpending.Entities.StatusSpending>();
            configuration.CreateMap<StatusSPUpdateDto, StatusSpending.Entities.StatusSpending>();
            #endregion

            #region Status
            configuration.CreateMap<Status.Entities.Status, StatusOutputDto>();
            configuration.CreateMap<StatusInputDto, Status.Entities.Status>();
            configuration.CreateMap<StatusUpdateDto, Status.Entities.Status>();
            #endregion

        }
    }
}
