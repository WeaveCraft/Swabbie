using Microsoft.EntityFrameworkCore;
using Swabbie_Business.Repository;
using Swabbie_Business.Repository.IRepository;
using Swabbie_DataAccess.Data;
using MudBlazor.Services;
using Swabbie_Business.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices();
builder.Services.AddMudBlazorDialog();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IIncomeRepository, IncomeRepository>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<ISavingRepository, SavingRepository>();
builder.Services.AddScoped<IOpenWeatherService, OpenWeatherService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
RequestLocalizationOptions GetLocalizationOptions()
{
    var cultures = builder.Configuration.GetSection("Cultures")
        .GetChildren().ToDictionary(x => x.Key, x => x.Value);

    var supportedCultures = cultures.Keys.ToArray();

    var localizationOptions = new RequestLocalizationOptions()
        .AddSupportedCultures(supportedCultures)
        .AddSupportedUICultures(supportedCultures);

    return localizationOptions;
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRequestLocalization(GetLocalizationOptions());

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
