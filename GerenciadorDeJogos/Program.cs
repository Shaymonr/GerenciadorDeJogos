using GerenciadorDeJogos.Context;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeJogos.Repositories;
using GerenciadorDeJogos.Repositories.Interfaces;

// Configura o builder para criar a aplicação web, definindo os serviços e o pipeline de processamento de requisições
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registra os repositórios de categorias e jogos para injeção de dependência, permitindo que as classes que dependem desses repositórios possam receber suas instâncias automaticamente
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();   
builder.Services.AddTransient<IJogosRepository, JogosRepository>();

// Configura o contexto do Entity Framework para usar SQL Server com a string de conexão definida no appsettings.json
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'REDACTED_PROJECT_NAMEContext' not found.")));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Configura o pipeline de processamento de requisições, definindo como a aplicação deve responder a diferentes tipos de requisições e erros    
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
