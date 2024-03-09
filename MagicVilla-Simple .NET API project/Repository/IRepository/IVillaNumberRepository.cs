using MagicVilla_Simple_.NET_API_project.Models;

namespace MagicVilla_Simple_.NET_API_project.Repository.IRepository
{
    public interface IVillaNumberRepository :IRepository<VillaNumber>
    { 
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
