using Code_First_Basic.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var coonectionstring = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(coonectionstring));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
