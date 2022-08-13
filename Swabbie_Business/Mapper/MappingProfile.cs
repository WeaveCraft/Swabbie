using AutoMapper;
using Swabbie_DataAccess.Transactions;
using Swabbie_Models.DTO.Transactions;

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
