using ContatosMVC.Data;
using Microsoft.EntityFrameworkCore;
using ContatosMVC.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContatosMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContatosMVCContext") ?? throw new InvalidOperationException("Connection string 'ContatosMVCContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContatosMVCContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ContatosMVCContext")));

builder.Services.AddRazorPages().AddMvcOptions(options => { options.MaxModelValidationErrors = 50; });
builder.Services.AddRazorPages().AddMvcOptions(options => { options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(_ => "Este campo é obrigatório"); });

builder.Services.AddScoped<SeedingService>();
builder.Services.AddScoped<SellerService>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

    app.UseHsts();

}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
