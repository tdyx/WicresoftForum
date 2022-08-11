using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WicresoftForumDataImport.Utils;
using WicresoftForumApi.Data;

namespace WicresoftForumDataImport.BasicImport
{
    class BasicDataImporter
    {
        private static readonly List<string> _mailPostfixes = new()
        {
            "163.com"
        };

        public static void UserImport()
        {
            var repo = CommonUtils.GetRepo();
            var userNames = new[]
            {
                "Admin",
                "张三",
                "李四",
                "王五",
            };
            var users = new List<User>();
            foreach (var userName in userNames)
            {
                users.Add(ConstructUser(userName));
            }
            _ = repo.ReFillUsers(users).Result;
        }

        private static User ConstructUser(string userName)
        {
            var mailPostfix = _mailPostfixes.OrderBy(item => Guid.NewGuid()).FirstOrDefault();
            return new User
            {
                UserName = userName,
                Password = "1",
                Email = $"{userName}@{mailPostfix}",
                UserType = userName == "admin" ? 0 : 1,
                CreateTime = DateTime.Now
            };
        }
    }
}
