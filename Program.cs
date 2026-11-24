 
using LojaApi.Data;
using LojaApi.Repositories;
using LojaApi.Services;
 
// Cria o configurador da aplicação e carrega suas configurações.
WebApplicationBuilder builder =
    WebApplication.CreateBuilder(args);
 
// Habilita os Controllers da aplicação.
builder.Services.AddControllers();
 
// Registra uma única instância de ConexaoBanco para a aplicação.
builder.Services.AddSingleton<ConexaoBanco>();
 
// Registra os Repositories responsáveis pelas consultas ao banco.
builder.Services.AddScoped<VendaRepository>();
builder.Services.AddScoped<ProdutoRepository>();
 
// Registra os Services responsáveis pelas operações da aplicação.
builder.Services.AddScoped<VendaService>();
builder.Services.AddScoped<ProdutoService>();
 
// Constrói a aplicação.
await using WebApplication app = builder.Build();
 
// Disponibiliza as rotas dos Controllers registrados.
app.MapControllers();
 
// Inicia a API.
await app.StartAsync();
 
// Exibe os endereços disponíveis.
Console.WriteLine();
Console.WriteLine("Listar vendas: http://localhost:5261/api/vendas");
Console.WriteLine("Listar produtos: http://localhost:5261/api/produtos");
Console.WriteLine("http://localhost:5261/api/conexao/testar");
 
// Mantém a API em execução até o encerramento com Ctrl + C.
await app.WaitForShutdownAsync();
 
 