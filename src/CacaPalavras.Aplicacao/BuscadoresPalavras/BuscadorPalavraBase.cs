namespace CacaPalavras.Aplicacao.BuscadoresPalavras
{
    public class BuscadorPalavraBase
    {
        protected readonly char[,] Matriz;

        protected BuscadorPalavraBase(char[,] matriz)
        {
            Matriz = matriz;
        }
    }
}