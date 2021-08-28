namespace CacaPalavras.Aplicacao.BuscadoresPalavras
{
    public class BuscadorPalavraCimaParaBaixo : BuscadorPalavraBase
    {
        public BuscadorPalavraCimaParaBaixo(char[,] matriz) : base(matriz)
        {
        }

        public bool BuscarPalavra(string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaLinha = indiceLinha + indiceLetraPalavra;
                if (indiceProximaLinha >= Matriz.GetLength(0))
                    return false;

                var proximaLetraMatriz = Matriz[indiceProximaLinha, indiceColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                    return false;
            }

            return true;
        }
    }
}