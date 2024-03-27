using SkillFactorySVN3211.DAL.Entities;

namespace SkillFactorySVN3211.DAL.Repositories
{
    public interface ILoggingRepository
    {
        Task AddRequest(Request request);

        Task<Request[]> GetRequests();
    }
}
