using WicresoftForumApi.Data;

namespace WicresoftForumApi.Services
{
    public class WicresoftForumRepo : IWicresoftForumRepo
    {
        private WicresoftForumContext _context;
        public WicresoftForumRepo(WicresoftForumContext wicresoftForumContext)
        {
            _context = wicresoftForumContext;
        }

        public Task<int> AddUsers(IList<User> users)
        {
            _context.Users.AddRange(users);
            return _context.SaveChangesAsync();
        }

        public Task<int> ReFillUsers(IList<User> users)
        {
            foreach (var user in _context.Users.ToList())
            {
                _context.Users.Remove(user);
            }
            _context.Users.AddRange(users);
            return _context.SaveChangesAsync();
        }
    }
}
