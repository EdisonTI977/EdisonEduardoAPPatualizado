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
    // Classe Placa
    public class Placa
    {
        // Propriedades
        public int IdPlaca { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }

        // Construtor da classe Placa
        public Placa(int idPlaca, string tipo, string tamanho, decimal preco)
        {
            IdPlaca = idPlaca;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;
        }

        // Método para inserir uma nova placa
        public static void Inserir(List<Placa> placas, Placa novaPlaca)
        {
            placas.Add(novaPlaca);
            Console.WriteLine("Placa inserida com sucesso!");
        }

        // Método para alterar os dados de uma placa existente
        public static void Alterar(List<Placa> placas, int id, string novoTipo, string novoTamanho, decimal novoPreco)
        {
            var placa = placas.FirstOrDefault(p => p.IdPlaca == id);
            if (placa != null)
            {
                placa.Tipo = novoTipo;
                placa.Tamanho = novoTamanho;
                placa.Preco = novoPreco;
                Console.WriteLine("Placa alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa não encontrada!");
            }
        }

        // Método para obter uma placa por ID
        public static Placa ObterPorId(List<Placa> placas, int id)
        {
            var placa = placas.FirstOrDefault(p => p.IdPlaca == id);
            return placa;
        }

        // Método para listar todas as placas
        public static void Listar(List<Placa> placas)
        {
            if (placas.Count > 0)
            {
                foreach (var placa in placas)
                {
                    Console.WriteLine($"ID: {placa.IdPlaca}, Tipo: {placa.Tipo}, Tamanho: {placa.Tamanho}, Preço: {placa.Preco:C}");
                }
            }
            else
            {
                Console.WriteLine("Não há placas cadastradas.");
            }
        }
    }
}
