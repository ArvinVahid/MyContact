using Microsoft.EntityFrameworkCore;
using MyContact.Business.Entities;
using MyContact.Business.IRepo;
using MyContact.Business.Services;
using MyContact.Business.Services.Interfaces;
using MyContact.Data;
using MyContact.Data.Repo;

namespace MyContact.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserRepo, UserRepo>();
            builder.Services.AddScoped<IContactRepo, ContactRepo>();
            builder.Services.AddScoped<INumberRepo, NumberRepo>();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IContactService, ContactService>();

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer("Server = eit-edusrv\\sql16; Initial Catalog = A.VahidKia ; Integrated Security = true; Trusted_Connection = true; Encrypt = false");
            });

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