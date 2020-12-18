namespace POO_Interface.Classes
{
    public interface Icarrinho
    {
         void Listar();

         void Cadastrar(Produto produto);

         void Alterar(int _codigo, Produto produto);

         void Deletar( Produto produto);
    }
}