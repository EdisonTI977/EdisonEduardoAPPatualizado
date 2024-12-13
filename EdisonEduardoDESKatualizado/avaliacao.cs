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
    public class avaliacao
    {
        // Propriedades
        public int IdAvaliacao { get; set; }
        public int IdPlaca { get; set; }
        public int IdCliente { get; set; }
        public double Nota { get; set; }
        public string Comentario { get; set; }

        // Construtor
        public avaliacao(int idAvaliacao, int idPlaca, int idCliente, double nota, string comentario)
        {
            IdAvaliacao = idAvaliacao;
            IdPlaca = idPlaca;
            IdCliente = idCliente;
            Nota = nota;
            Comentario = comentario;
        }

        // Método para inserir uma nova avaliação
        public static void Inserir(List<avaliacao> avaliacoes, avaliacao novaAvaliacao)
        {
            avaliacoes.Add(novaAvaliacao);
            Console.WriteLine("Avaliação inserida com sucesso!");
        }

        // Método para alterar uma avaliação existente
        public static void Alterar(List<avaliacao> avaliacoes, int id, double novaNota, string novoComentario)
        {
            var avaliacao = avaliacoes.FirstOrDefault(a => a.IdAvaliacao == id);
            if (avaliacao != null)
            {
                avaliacao.Nota = novaNota;
                avaliacao.Comentario = novoComentario;
                Console.WriteLine("Avaliação alterada com sucesso!");
            }
            else
            {
                Console.WriteLine("Avaliação não encontrada!");
            }
        }

        // Método para obter uma avaliação por ID
        public static avaliacao ObterPorId(List<avaliacao> avaliacoes, int id)
        {
            return avaliacoes.FirstOrDefault(a => a.IdAvaliacao == id);
        }

        // Método para listar todas as avaliações
        public static void Listar(List<avaliacao> avaliacoes)
        {
            if (avaliacoes.Count > 0)
            {
                foreach (var avaliacao in avaliacoes)
                {
                    Console.WriteLine($"ID: {avaliacao.IdAvaliacao}, Placa ID: {avaliacao.IdPlaca}, " +
                                      $"Cliente ID: {avaliacao.IdCliente}, Nota: {avaliacao.Nota}, " +
                                      $"Comentário: {avaliacao.Comentario}");
                }
            }
            else
            {
                Console.WriteLine("Não há avaliações cadastradas.");
            }
        }
    }
}

