using MagicVilla_Simple_.NET_API_project.Models;
using System.Linq.Expressions;

namespace MagicVilla_Simple_.NET_API_project.Repository.IRepository
{
    public interface IVillaRepository 
    {
        Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null);
        Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked=true);
        Task Create(Villa entity);
        Task Remove(Villa entity);
        Task Save();
    }
}
