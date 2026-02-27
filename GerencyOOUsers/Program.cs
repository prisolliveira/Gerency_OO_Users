using GerencyOOUsers.Data;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.
    GetConnectionString("UsersConnectionString");

Console.WriteLine(connection);

builder.Services.AddDbContext<UsuariosContext>(op => op.
    UseMySql(connection, ServerVersion.AutoDetect(connection)));

builder.Services.AddControllersWithViews();
builder.Services.AddOpenApi();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Acesso/Error");
    app.UseHsts();

} else
{
    app.MapOpenApi();
    app.MapScalarApiReference();

}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Acesso}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
