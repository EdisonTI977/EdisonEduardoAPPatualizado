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
    public class Encomenda
    {
        // Propriedades
        public int IdEncomenda { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataEncomenda { get; set; }
        public string Status { get; set; }
        public DateTime? DataEntrega { get; set; }

        // Construtor
        public Encomenda(int idEncomenda, int idCliente, DateTime dataEncomenda, string status, DateTime? dataEntrega = null)
        {
            IdEncomenda = idEncomenda;
            IdCliente = idCliente;
            DataEncomenda = dataEncomenda;
            Status = status;
            DataEntrega = dataEntrega;
        }

        // Método para inserir uma nova encomenda
        public static void Inserir(List<Encomenda> encomendas, Encomenda novaEncomenda)
        {
            encomendas.Add(novaEncomenda);
            Console.WriteLine("Encomenda inserida com sucesso!");
        }

        // Método para alterar dados de uma encomenda
        public static void Alterar(List<Encomenda> encomendas, int id, string novoStatus, DateTime? novaDataEntrega)
        {
            var encomenda = encomendas.FirstOrDefault(e => e.IdEncomenda == id);
            if (encomenda != null)
            {
                encomenda.Status = novoStatus;
                encomenda.DataEntrega = novaDataEntrega;
                Console.WriteLine("Encomenda alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Encomenda não encontrada!");
            }
        }

        // Método para obter uma encomenda por ID
        public static Encomenda ObterPorId(List<Encomenda> encomendas, int id)
        {
            return encomendas.FirstOrDefault(e => e.IdEncomenda == id);
        }

        // Método para listar todas as encomendas
        public static void Listar(List<Encomenda> encomendas)
        {
            if (encomendas.Count > 0)
            {
                foreach (var encomenda in encomendas)
                {
                    Console.WriteLine($"ID: {encomenda.IdEncomenda}, Cliente ID: {encomenda.IdCliente}, " +
                                      $"Data Encomenda: {encomenda.DataEncomenda.ToShortDateString()}, " +
                                      $"Status: {encomenda.Status}, " +
                                      $"Data Entrega: {encomenda.DataEntrega?.ToShortDateString() ?? "Não entregue"}");
                }
            }
            else
            {
                Console.WriteLine("Não há encomendas cadastradas.");
            }
        }
    }
}

