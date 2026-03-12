namespace Revisao
{
    internal class Program 
    {
        static void main(string[] args)
        {
            using var context = new AppDbContext();

            contexto.Database.EnsureCreated();
            // Database.EnsureCreated() -> Verifica se o banco de dados existe, se não existir, ele cria o banco de dados e as tabelas com base nas entidades definidas no contexto.

            var controller = new ProdutoController(contexto);
            // instancia o controller, passando o contexto do banco de dados para que o controller possa acessar os dados e realizar as operações necessárias.
            var view = new ProdutoView(controller);
            // instancia a view, passando o controller para que a view possa chamar os métodos do controller e exibir as informações para o usuário.

            view.Menu();
            // chama o método Menu da view, que exibe o menu para o usuário e permite que ele escolha as opções para cadastrar ou listar produtos, ou sair do programa.
        } 
    }
}
