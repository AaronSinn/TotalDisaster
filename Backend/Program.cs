using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("DefaultConnection");
//TODO: Use connString
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(
    @"Host=localhost;Port=5432;Username=postgres;Password=37800590;Database=TotalDisaster"));

var app = builder.Build();

app.Run();