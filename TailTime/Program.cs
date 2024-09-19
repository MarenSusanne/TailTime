
using Microsoft.Data.SqlClient;

namespace TailTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queries().Wait();


            /*var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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

            app.Run();*/
        }

        static async Task Queries()
        {
            string connectionString = "Server=MST\\LOCALDB#B8EE8BFB;Database=DogTraining;Integrated Security=True;";

            var conn = new SqlConnection(connectionString);


        }
    }
}
