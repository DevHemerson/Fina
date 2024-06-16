using Fina.Api.Data;
using Fina.Api.Handlers;
using Fina.Core.Handlers;
using Fina.Core.Requests.Categories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

const string connectionString = "server=LAPTOP-696GJNV6\\SQLEXPRESS01;database=fina;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";

builder.Services.AddDbContext<AppDbContext>(
    x => x.UseSqlServer(connectionString));

builder.Services.AddTransient<ICategoryHandler, CategoryHandler>();
builder.Services.AddTransient<ITransactionHandler, TransactionHandler>();

var app = builder.Build();

app.Run();
