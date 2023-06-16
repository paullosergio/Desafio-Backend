using Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/cliente", (Cliente cliente) => "Cliente cadastrar"+cliente.Nome);

app.Run();
