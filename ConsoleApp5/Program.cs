namespace RonaldoTestes
{

    /*Ronaldo Automoveis
     * Cadastrar Veículos
     * Consultar Estoque
     * Registrar Venda
     * Registrar Cliente
     * Histórico de Vendas
     */
    using System;
    using System.Collections.Generic;
    class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Renavam { get; set; }
        public double Kilometros { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
    }
    internal class Program
    {
        static List<Veiculo> estoque = new List<Veiculo>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("┌──────────────────────────┐");
                Console.WriteLine("│R O N A L D O   A U T O S │");
                Console.WriteLine("└──────────────────────────┘");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastrar Veículos");
                Console.WriteLine("2. Consultar Estoque");
                Console.WriteLine("3. Registrar Venda");
                Console.WriteLine("4. Registrar Cliente");
                Console.WriteLine("5. Histórico de Vendas");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Opção 1 selecionada: Cadastrar Veículos");
                        CadastrarVeiculo();
                        break;
                    case 2:
                        Console.WriteLine("Opção 2 selecionada: Consultar Estoque");
                        ConsultarEstoque();
                        break;
                    case 3:

                        Console.WriteLine("Opção 3 selecionada: Registrar Venda");
                        break;
                    case 4:

                        Console.WriteLine("Opção 4 selecionada: Registrar Cliente");

                        break;
                    case 5:

                        Console.WriteLine("Opção 5 selecionada: Histórico de Vendas");
                        break;
                    case 0:
                        // Encerrar o programa
                        Console.WriteLine("Encerrando o programa. Obrigado!");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
        static void CadastrarVeiculo()
        {
            Veiculo novoVeiculo = new Veiculo();
            Console.Write("Placa: ");
            novoVeiculo.Placa = Console.ReadLine();
            Console.Write("Modelo: ");
            novoVeiculo.Modelo = Console.ReadLine();
            Console.Write("Renavam: ");
            novoVeiculo.Renavam = Console.ReadLine();
            Console.Write("Kilometros: ");
            novoVeiculo.Kilometros = double.Parse(Console.ReadLine());
            Console.Write("Marca: ");
            novoVeiculo.Marca = Console.ReadLine();
            Console.Write("Ano: ");
            novoVeiculo.Ano = int.Parse(Console.ReadLine());
            Console.Write("Preco: ");
            novoVeiculo.Preco = int.Parse(Console.ReadLine());
            estoque.Add(novoVeiculo);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }
        static void ConsultarEstoque()
        {
            Console.WriteLine("Estoque de Veículos:");
            foreach (var veiculo in estoque)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Renavam: {veiculo.Renavam}, Kilometros: {veiculo.Kilometros}, Marca: {veiculo.Marca}, Ano: {veiculo.Ano}, Preço: {veiculo.Preco:C}");
            }
        }
    }
}