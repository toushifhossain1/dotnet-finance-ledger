using FinanceSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

// Register InvoiceService so DI can inject it into InvoiceController
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