using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WicresoftForumApi.Data;
using WicresoftForumApi.Services;

namespace WicresoftForumDataImport.Utils
{
    public static class CommonUtils
    {
        private const string API_CONFIGURATION_JSON_NAME = "appsettings.json";
        private const string DBNAME = "WicresoftForumDatabase";

        public static IConfigurationRoot GetApiConfiguration()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(Environment.CurrentDirectory, API_CONFIGURATION_JSON_NAME));

            return builder.Build();
        }

        public static string GetDBConnectionString()
        {
            var apiConfiguration = GetApiConfiguration();
            return apiConfiguration.GetConnectionString(DBNAME);
        }

        public static WicresoftForumContext GetContext()
        {
            return new WicresoftForumContext(new DbContextOptionsBuilder<WicresoftForumContext>()
                .UseSqlServer(GetDBConnectionString())
                .Options);
        }

        public static WicresoftForumRepo GetRepo()
        {
            return new WicresoftForumRepo(GetContext());
        }
    }
}
