using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Swabbie_Business.Repository.IRepository;
using Swabbie_DataAccess.Data;
using Swabbie_DataAccess.Transactions;
using Swabbie_Models.DTO.Transactions;

namespace Swabbie_Business.Repository
{
    public class SavingRepository : ISavingRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public SavingRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<SavingDTO> Create(SavingDTO objDTO)
        {
            var obj = _mapper.Map<SavingDTO, Saving>(objDTO);
            var addedObj = _db.Savings.Add(obj);
            await _db.SaveChangesAsync();

            return _mapper.Map<Saving, SavingDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = await _db.Savings.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Savings.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<SavingDTO> Get(int id)
        {
            var obj = await _db.Savings.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<Saving, SavingDTO>(obj);
            }
            return new SavingDTO();
        }

        public async Task<IEnumerable<SavingDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Saving>, IEnumerable<SavingDTO>>(_db.Savings);
        }

        public async Task<SavingDTO> Update(SavingDTO objDTO)
        {
            var objFromDb = await _db.Savings.FirstOrDefaultAsync(u => u.Id == objDTO.Id);
            if (objFromDb != null)
            {
                objFromDb.Description = objDTO.Description;
                objFromDb.TransactionDate = objDTO.TransactionDate;
                objFromDb.CreatedDate = DateTime.UtcNow;
                objFromDb.Amount = objDTO.Amount;
                objFromDb.Category = objDTO.Category;
                _db.Savings.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Saving, SavingDTO>(objFromDb);
            }
            return objDTO;

        }
    }
}
