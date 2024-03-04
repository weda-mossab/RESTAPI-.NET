using Microsoft.EntityFrameworkCore;
using RestAPI.Data;
using RestAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Ajouté Le repository.
builder.Services.AddScoped<OffreRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurer et Enregistrer le DbContext nommé DataContext dans le conteneur de services
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
