using Microsoft.EntityFrameworkCore;
using Transaction_Summerizer_Models;
using Transaction_Summerizer.Services;
using Transaction_Summerizer_Persistance;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register DbContext with SQL Server
builder.Services.AddDbContext<SummerizerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register custom service layer
builder.Services.AddScoped<ITransactionService, TransactionService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}
else

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
