using Model;
using Repository;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var clienteRepository = new ClienteRepository();

app.MapGet("/", () => "Hello World!");
app.MapPost("/cliente", (Cliente cliente) => {
    var clienteSalvo = clienteRepository.Salvar(cliente);
    return "Cliente salvo com sucesso!" + clienteSalvo.Id;
});

app.Run();
