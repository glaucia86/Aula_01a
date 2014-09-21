using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_01.Model;

namespace Projeto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dados do Passageiro
            //Dados do Passageiro:
            Passageiro pa = new Passageiro();

            pa.IdPessoa = 1;
            pa.Nome = "Glaucia Lemos";
            pa.NumeroCadeira = "K05";
            pa.NumeroSmiles = "152LOK150";
            pa.endereco = new Endereco();

            pa.endereco.Logradouro = "Rua Porto Santana, 316, Vila Valqueire";
            pa.endereco.Estado = "Rio de Janeiro";

            Console.WriteLine("\tDados do Passageiro\n");
            Console.WriteLine("Id do Passageiro......: " + pa.IdPessoa);
            Console.WriteLine("Nome do Passageiro.....:  " + pa.Nome);
            Console.WriteLine("Número Smiles....:  " + pa.NumeroSmiles);
            Console.WriteLine("Número da Poltrona......: " + pa.NumeroCadeira);
            Console.WriteLine("Endereço do Passageiro......: " + pa.endereco.Logradouro);
            Console.WriteLine("Estado......: " + pa.endereco.Estado);

            #endregion

            Console.WriteLine("\n-----------------------------------------------------------------");

            #region Dados da Tripulação

            // Dados da Tripulação
            Tripulacao tr = new Tripulacao();

            tr.IdPessoa = 1;
            tr.Nome = "Jurema Lemos";
            tr.NumeroVoo = "FL0555";
            tr.endereco = new Endereco();

            tr.endereco.Logradouro = "Av. Atlantica, 3500, apt 1002, Copacabana";
            tr.endereco.Estado = "Rio de Janeiro";

            Console.WriteLine("\tDados da Tripulação\n");
            Console.WriteLine("Id da Tripulante......: " + tr.IdPessoa);
            Console.WriteLine("Nome do Tripulante.....: " + tr.Nome);
            Console.WriteLine("Número do Voô.....: " + tr.NumeroVoo);
            Console.WriteLine("Endereço.....:  " + tr.endereco.Logradouro);
            Console.WriteLine("Estadao......: " + tr.endereco.Estado);

            #endregion

            Console.WriteLine("\n-------------------------------------------------------------------");

            #region Dados do Agente

            //Dados do Agente:
            Agente a = new Agente();

            a.IdPessoa = 1;
            a.Nome = "Alessandra Freitas";
            a.ComissaoVenda = 5550.00;
            a.endereco = new Endereco();

            a.endereco.Logradouro = "Rua Alberto Sabino, 789, Tijuca";
            a.endereco.Estado = "Rio de Janeiro";

            Console.WriteLine("Id do Agente.....: " + a.IdPessoa);
            Console.WriteLine("Nome do Agente.....: " + a.Nome);
            Console.WriteLine("Comissão de Venda......: R$ " + a.ComissaoVenda);
            Console.WriteLine("Endereço.......: " + a.endereco.Logradouro);
            Console.WriteLine("Estado........: " + a.endereco.Estado);

            #endregion

            Console.ReadKey();
            
            
        }
    }
}
