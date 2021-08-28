using CacaPalavras.Aplicacao.BuscadoresPalavras;

namespace CacaPalavras.Aplicacao
{
    public class BuscadorPalavra
    {
        private readonly char[,] _matriz;
        private readonly BuscadorPalavraEsquerdaParaDireita _buscadorEsquerdaParaDireita;
        private readonly BuscadorPalavraDireitaParaEsquerda _buscadorDireitaParaEsquerda;
        private readonly BuscadorPalavraCimaParaBaixo _buscadorCimaParaBaixo;
        private readonly BuscadorPalavraBaixoParaCima _buscadorBaixoParaCima;

        public BuscadorPalavra(char[,] matriz)
        {
            _matriz = matriz;
            _buscadorEsquerdaParaDireita = new BuscadorPalavraEsquerdaParaDireita(_matriz);
            _buscadorDireitaParaEsquerda = new BuscadorPalavraDireitaParaEsquerda(_matriz);
            _buscadorCimaParaBaixo = new BuscadorPalavraCimaParaBaixo(_matriz);
            _buscadorBaixoParaCima = new BuscadorPalavraBaixoParaCima(_matriz);
        }

        public bool BuscarPalavra(string palavra)
        {
            for (int indiceLinha = 0; indiceLinha < _matriz.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < _matriz.GetLength(1); indiceColuna++)
                {
                    var letraAtualMatriz = _matriz[indiceLinha, indiceColuna];
                    var primeiraLetraPalavra = palavra[0];

                    if (letraAtualMatriz == primeiraLetraPalavra)
                    {
                        if (_buscadorEsquerdaParaDireita.BuscarPalavra(palavra, indiceLinha, indiceColuna)) return true;
                        if (_buscadorDireitaParaEsquerda.BuscarPalavra(palavra, indiceLinha, indiceColuna)) return true;
                        if (_buscadorCimaParaBaixo.BuscarPalavra(palavra, indiceLinha, indiceColuna)) return true;
                        if (_buscadorBaixoParaCima.BuscarPalavra(palavra, indiceLinha, indiceColuna)) return true;

                        return false;
                    }
                }
            }

            return false;
        }
    }
}