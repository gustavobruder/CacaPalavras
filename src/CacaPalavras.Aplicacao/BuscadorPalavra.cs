namespace CacaPalavras.Aplicacao
{
    public class BuscadorPalavra
    {
        public bool BuscarPalavraEsquerdaParaDireita(char[,] matriz, string palavra)
        {
            var encontrou = false;

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        encontrou = true;

                        for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
                        {
                            var proximaLetraMatriz = matriz[indiceLinha, indiceColuna + indiceLetraPalavra];
                            var proximaLetraPalavra = palavra[indiceLetraPalavra];
                            if (proximaLetraMatriz != proximaLetraPalavra)
                            {
                                encontrou = false;
                            }
                        }
                    }
                }
            }

            return encontrou;
        }

        public bool BuscarPalavraDireitaParaEsquerda(char[,] matriz, string palavra)
        {
            var encontrou = false;

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        encontrou = true;

                        for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
                        {
                            var proximaLetraMatriz = matriz[indiceLinha, indiceColuna - indiceLetraPalavra];
                            var proximaLetraPalavra = palavra[indiceLetraPalavra];
                            if (proximaLetraMatriz != proximaLetraPalavra)
                            {
                                encontrou = false;
                            }
                        }
                    }
                }
            }

            return encontrou;
        }

        public bool BuscarPalavraCimaParaBaixo(char[,] matriz, string palavra)
        {
            var encontrou = false;

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        encontrou = true;

                        for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
                        {
                            var proximaLetraMatriz = matriz[indiceLinha + indiceLetraPalavra, indiceColuna];
                            var proximaLetraPalavra = palavra[indiceLetraPalavra];
                            if (proximaLetraMatriz != proximaLetraPalavra)
                            {
                                encontrou = false;
                            }
                        }

                        if (encontrou) return true;
                    }
                }
            }

            return encontrou;
        }

        public bool BuscarPalavraBaixoParaCima(char[,] matriz, string palavra)
        {
            var encontrou = false;

            for (int indiceLinha = 0; indiceLinha < matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        encontrou = true;

                        for (var indiceLetraPalavra = 0; indiceLetraPalavra < palavra.Length; indiceLetraPalavra++)
                        {
                            var proximaLetraMatriz = matriz[indiceLinha - indiceLetraPalavra, indiceColuna];
                            var proximaLetraPalavra = palavra[indiceLetraPalavra];
                            if (proximaLetraMatriz != proximaLetraPalavra)
                            {
                                encontrou = false;
                            }
                        }

                        if (encontrou) return true;
                    }
                }
            }

            return encontrou;
        }
    }
}