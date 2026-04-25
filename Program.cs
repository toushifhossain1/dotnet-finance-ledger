using FinanceSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Register services so DI can inject them into their respective controllers
builder.Services.AddSingleton<InvoiceService>();
builder.Services.AddSingleton<PaymentService>();
builder.Services.AddSingleton<JournalService>();

var app = builder.Build();

// Configure pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllers();

// Test endpoint
app.MapGet("/", () => "Finance API is running...");

app.Run();