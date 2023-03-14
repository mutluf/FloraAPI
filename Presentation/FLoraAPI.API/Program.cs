using FLoraAPI.Persistence;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Programcs�e servis olarak eklemek gerek contexti
//e�er bir s�n�f �zerinden y�r�teceksen b�t�n servisleri o metodu eklemek gerek.
builder.Services.AddPersistenceServices();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
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


//unable to create an object of type FloraAPIDbContext hatas� i�in Persistence'a nuget sql eklendi. �ncesinde floraapi.api'ye de eklenmi�ti.