using Model;
namespace Repository
{
class ClienteRepository
    {
        public Cliente Salvar(Cliente cliente)
        {
            Console.WriteLine("Salvando " + cliente.Nome);
            var novoCliente = new Cliente(1, cliente.Nome, cliente.Idade, cliente.Email);
            return novoCliente;
        }
    }
}