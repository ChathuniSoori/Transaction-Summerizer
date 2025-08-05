using Microsoft.EntityFrameworkCore;
using Transaction_Summerizer_Models;
using Transaction_Summerizer.Services;
using Transaction_Summerizer_Persistance;
using Transaction_Summerizer_Services;

var builder = WebApplication.CreateBuilder(args);

//Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Register custom service layer
builder.Services.AddScoped<ITransactionService, TransactionSQLServerService>();

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
