using SkillFactorySVN3211.DAL.Entities;

namespace SkillFactorySVN3211.DAL.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}
