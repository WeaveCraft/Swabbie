using Swabbie_Models.DTO;

namespace Swabbie_Business.Repository.IRepository
{
    public interface IIncomeRepository
    {
        public Task<IncomeDTO> Create(IncomeDTO objDTO);
        public Task<IncomeDTO> Update(IncomeDTO objDTO);
        public Task<int> Delete(int id);
        public Task<IncomeDTO> Get(int id);
        public Task<IEnumerable<IncomeDTO>> GetAll();
    }
}
