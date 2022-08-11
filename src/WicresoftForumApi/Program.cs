using WicresoftForumApi.Data;
using Microsoft.EntityFrameworkCore;

namespace WicresoftForumApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WicresoftForumContext
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WicresoftForumContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("WicresoftForumDatabase")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}