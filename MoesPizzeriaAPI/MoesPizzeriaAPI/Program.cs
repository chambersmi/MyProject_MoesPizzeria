
using Microsoft.EntityFrameworkCore;
using MoesPizzeriaAPI.Models;

namespace MoesPizzeriaAPI
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

            //ANGULAR
            builder.Services.AddCors();
            var configuration = builder.Configuration;
            builder.Services.AddDbContext<ItemDetailContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("PizzeriaConnection")));

            var app = builder.Build();

            //ANGULAR
            app.UseCors(options => options.WithOrigins("https://localhost:4200").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}