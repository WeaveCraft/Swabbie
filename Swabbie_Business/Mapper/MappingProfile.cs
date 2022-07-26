using AutoMapper;
using Swabbie_DataAccess.Models;
using Swabbie_Models.DTO;

namespace Swabbie_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Income, IncomeDTO>().ReverseMap();
            CreateMap<Expense, ExpenseDTO>().ReverseMap();
        }
    }
}
