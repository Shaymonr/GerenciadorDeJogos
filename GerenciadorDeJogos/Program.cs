using GerenciadorDeJogos.Context;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeJogos.Repositories;
using GerenciadorDeJogos.Repositories.Interfaces;
//Nota de estudo:
//O código a seguir é o ponto de entrada da aplicação ASP.NET Core, onde a configuração dos serviços e
//do pipeline de processamento de requisições é realizada. Ele utiliza o padrão de injeção de dependência
//para registraros repositórios e configura o Entity Framework para acessar o banco de dados SQL Server.
//A classe Program é responsável por configurar e iniciar a aplicação, definindo os serviços
//necessários e o comportamento da aplicação em diferentes ambientes (desenvolvimento, produção, etc.).
//O método Main é o ponto de entrada da aplicação, onde o builder é configurado e a aplicação é executada.
//Antes era dividida em dois arquivos, Program.cs e Startup.cs, mas a partir do .NET 6, a configuração foi
//unificada em um único arquivo, simplificando o processo de configuração da aplicação.


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
