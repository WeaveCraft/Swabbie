using Swabbie_Models.DTO.Transactions;

namespace Swabbie_Business.Repository.IRepository
{
    public interface ISavingRepository
    {
        public Task<SavingDTO> Create(SavingDTO objDTO);
        public Task<SavingDTO> Update(SavingDTO objDTO);
        public Task<int> Delete(int id);
        public Task<SavingDTO> Get(int id);
        public Task<IEnumerable<SavingDTO>> GetAll();
    }
}
