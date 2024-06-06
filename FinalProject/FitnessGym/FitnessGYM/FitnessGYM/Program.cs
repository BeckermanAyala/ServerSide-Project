using BL;
using Dal;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("DB");
//string connStr = builder.Configuration.GetConnectionString("DB");
builder.Services.AddSingleton<BLManager>(sp => new BLManager(connStr));



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddSingleton<DBActions>();



// Register BLManager with connection string


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
