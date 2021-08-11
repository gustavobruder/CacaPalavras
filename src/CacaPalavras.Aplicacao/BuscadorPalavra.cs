namespace CacaPalavras.Aplicacao
{
    public class BuscadorPalavra
    {
        public bool BuscarPalavra(char[,] matriz, string palavra)
        {
            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        if (BuscarPalavraEsquerdaParaDireita(matriz, palavra, indiceLinha, indiceColuna)) return true;
                        if (BuscarPalavraDireitaParaEsquerda(matriz, palavra, indiceLinha, indiceColuna)) return true;
                        if (BuscarPalavraCimaParaBaixo(matriz, palavra, indiceLinha, indiceColuna)) return true;
                        if (BuscarPalavraBaixoParaCima(matriz, palavra, indiceLinha, indiceColuna)) return true;

                        return false;
                    }
                }
            }

            return false;
        }

        public bool BuscarPalavraEsquerdaParaDireita(char[,] matriz, string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaColuna = indiceColuna + indiceLetraPalavra;
                if (indiceProximaColuna >= matriz.GetLength(1)) return false;

                var proximaLetraMatriz = matriz[indiceLinha, indiceProximaColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                {
                    return false;
                }
            }

            return true;
        }

        public bool BuscarPalavraDireitaParaEsquerda(char[,] matriz, string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaColuna = indiceColuna - indiceLetraPalavra;
                if (indiceProximaColuna < 0) return false;

                var proximaLetraMatriz = matriz[indiceLinha, indiceProximaColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                {
                    return false;
                }
            }

            return true;
        }

        public bool BuscarPalavraCimaParaBaixo(char[,] matriz, string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaLinha = indiceLinha + indiceLetraPalavra;
                if (indiceProximaLinha >= matriz.GetLength(0)) return false;

                var proximaLetraMatriz = matriz[indiceProximaLinha, indiceColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                {
                    return false;
                }
            }

            return true;
        }

        public bool BuscarPalavraBaixoParaCima(char[,] matriz, string palavra, int indiceLinha, int indiceColuna)
        {
            for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
            {
                var indiceProximaLinha = indiceLinha - indiceLetraPalavra;
                if (indiceProximaLinha < 0) return false;

                var proximaLetraMatriz = matriz[indiceProximaLinha, indiceColuna];
                var proximaLetraPalavra = palavra[indiceLetraPalavra];
                if (proximaLetraMatriz != proximaLetraPalavra)
                {
                    return false;
                }
            }

            return true;
        }
    }
}