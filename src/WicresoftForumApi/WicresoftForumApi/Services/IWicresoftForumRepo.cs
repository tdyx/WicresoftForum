using WicresoftForumApi.Data;

namespace WicresoftForumApi.Services
{
    public interface IWicresoftForumRepo
    {
        Task<int> AddUsers(IList<User> users);
        Task<int> ReFillUsers(IList<User> users);
    }
}
