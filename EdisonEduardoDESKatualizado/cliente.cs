using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

namespace EdisonEduardoCLASSatualizado
{
    // Classe Cliente
    public class Cliente
    {
        // Propriedades
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        // Construtor para inicializar um novo cliente
        public Cliente(int idCliente, string nome, string email, string telefone, string endereco)
        {
            IdCliente = idCliente;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        // Método para inserir um novo cliente
        public static void Inserir(List<Cliente> clientes, Cliente novoCliente)
        {
            clientes.Add(novoCliente);
            Console.WriteLine("Cliente inserido com sucesso!");
        }

        // Método para alterar dados do cliente
        public static void Alterar(List<Cliente> clientes, int id, string novoNome, string novoEmail, string novoTelefone, string novoEndereco)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente != null)
            {
                cliente.Nome = novoNome;
                cliente.Email = novoEmail;
                cliente.Telefone = novoTelefone;
                cliente.Endereco = novoEndereco;
                Console.WriteLine("Cliente alterado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        // Método para obter cliente por ID
        public static Cliente ObterPorId(List<Cliente> clientes, int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.IdCliente == id);
            if (cliente != null)
            {
                return cliente;
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
                return null;
            }
        }

        // Método para listar todos os clientes
        public static void Listar(List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.IdCliente}, Nome: {cliente.Nome}, Email: {cliente.Email}, Telefone: {cliente.Telefone}, Endereço: {cliente.Endereco}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
            }
        }
    }

    // Classe Program para testar os métodos
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();

            // Inserir novos clientes
            Cliente.Inserir(clientes, new Cliente(1, "João Silva", "joao@example.com", "1234-5678", "Rua A, 123"));
            Cliente.Inserir(clientes, new Cliente(2, "Maria Oliveira", "maria@example.com", "2345-6789", "Rua B, 456"));

            // Listar todos os clientes
            Console.WriteLine("Lista de clientes:");
            Cliente.Listar(clientes);

            // Alterar um cliente
            Cliente.Alterar(clientes, 1, "João Silva Santos", "joao.santos@example.com", "1234-5678", "Rua A, 1234");

            // Listar novamente
            Console.WriteLine("\nLista de clientes após alteração:");
            Cliente.Listar(clientes);

            // Obter um cliente por ID
            var clienteBuscado = Cliente.ObterPorId(clientes, 1);
            if (clienteBuscado != null)
            {
                Console.WriteLine($"\nCliente encontrado: {clienteBuscado.Nome}, Email: {clienteBuscado.Email}");
            }

            Console.ReadLine();
        }
    }
}
