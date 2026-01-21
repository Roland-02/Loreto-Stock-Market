using WizardStockExchange.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<GameState>();
builder.Services.AddSingleton<StockDataService>();
builder.Services.AddSingleton<TradingService>();
builder.Services.AddSingleton<LoanService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

var stockService = app.Services.GetRequiredService<StockDataService>();
stockService.LoadInitialStocks();
stockService.StartPriceUpdates();

app.Run();
