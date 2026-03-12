namespace Revisao
{
    public class ProdutoView
    {
        private readonly ProdutoController _controller;

        public ProdutoView(ProdutoController controller)
        {
            _controller = controller;
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.Whriteline("Revisão C#");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                var op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "0":

                        return;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private void CadastrarProduto()
        {
            // ?? string.Empty -> se o valor for nulo, atribui string.Empty
            // decimal.Parse -> converte a string para decimal
            // int.Parse -> converte a string para inteiro
            Console.Clear();
            Console.WriteLine("=== Cadastro de Produto ===");
            Console.Write("Nome: ");
            var nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.Write("Estoque: ");
            int estoque = int.Parse(Console.ReadLine());

            var produto = _controller.CriarProduto(nome, preco, estoque);
            // chama o método CriarProduto do controller, passando os dados do produto e recebe o produto criado

            Console.WriteLine($"Produto com o ID {produto.Id}");
            Console.ReadKey();
        }

        private void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Produtos ===");
            var produtos = _controller.ListarProdutos();

            if (!produtos.Any()) // verifica se a lista de produtos está vazia
            {
                Console.Writeline("Nenhum produto encontrado.");
            }
            else
            {
                foreach (var p in produtos)
                // percorre a lista de produtos e exibe as informações de cada produto
                {
                    Console.WriteLine(
                        $"{p.Id} - {p.Nome} - R$ {p.preco} - Estoque: {p.Estoque}"
                    // exibe o ID, nome, preço e estoque de cada produto
                    );
                }
            }
            Console.ReadKey(); // aguarda o usuário pressionar uma tecla antes de voltar ao menu
        }
    }
}