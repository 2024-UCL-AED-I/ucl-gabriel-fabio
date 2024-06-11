/*Ronaldo Automoveis
 * Cadastrar Veículos
 * Consultar Estoque
 * Registrar Venda
 * Registrar Cliente
 * Histórico de Vendas
 */
namespace Ronaldo_Autos
{
    internal class Program
        class veiculo
    {
        private string marca, modelo;
        private int ano, kilometragem;
        private decimal preco;
        public veiculo(string ma, string mo, int a, int km, decimal pre)
        {
            marca = ma;
            modelo = mo;
            ano = a;
            kilometragem = km;
            preco = pre;
        }
        public string getMarca()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }
        public int getAno()
        {
            return ano;
        }
        public int getKM()
        {
            return kilometragem;
        }
        public int getAno()
        {
            return ano;
        }
        public decimal getPreco()
        {
            return preco;
        }
    }

            {
        static void Main(string[] args)
        {
                    while (true)
        {
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────┐")
            Console.WriteLine("│ ____   ___  _   _    _    _     ____   ___       _   _   _ _____ ___  ____  │")
            Console.WriteLine("│|  _ \ / _ \| \ | |  / \  | |   |  _ \ / _ \     / \ | | | |_   _/ _ \/ ___| │")
            Console.WriteLine("│| |_) | | | |  \| | / _ \ | |   | | | | | | |   / _ \| | | | | || | | \___ \ │")
            Console.WriteLine("│|  _ <| |_| | |\  |/ ___ \| |___| |_| | |_| |  / ___ \ |_| | | || |_| |___) |│")
            Console.WriteLine("│|_| \_\\___/|_| \_/_/   \_\_____|____/ \___/  /_/   \_\___/  |_| \___/|____/ │")
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘")
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
                    break;
                case 2:
                    Console.WriteLine("Opção 2 selecionada: Consultar Estoque");
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
}
}
            