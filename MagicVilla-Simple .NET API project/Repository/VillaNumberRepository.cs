using MagicVilla_Simple_.NET_API_project.Data;
using MagicVilla_Simple_.NET_API_project.Models;
using MagicVilla_Simple_.NET_API_project.Repository.IRepository;

namespace MagicVilla_Simple_.NET_API_project.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        public readonly ApplicationDbContext _db;

        public VillaNumberRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.villaNumbers.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
