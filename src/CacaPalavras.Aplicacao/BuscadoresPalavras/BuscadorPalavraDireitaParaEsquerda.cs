namespace CacaPalavras.Aplicacao.BuscadoresPalavras
{
    public class BuscadorPalavraDireitaParaEsquerda : BuscadorPalavraBase
    {
        public BuscadorPalavraDireitaParaEsquerda(char[,] matriz) : base(matriz)
        {
        }

        public bool BuscarPalavra(string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaColuna = indiceColuna - indiceLetraPalavra;
                if (indiceProximaColuna < 0)
                    return false;

                var proximaLetraMatriz = Matriz[indiceLinha, indiceProximaColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                    return false;
            }

            return true;
        }
    }
}