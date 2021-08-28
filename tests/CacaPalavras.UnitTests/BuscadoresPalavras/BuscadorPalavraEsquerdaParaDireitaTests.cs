using CacaPalavras.Aplicacao;
using CacaPalavras.Aplicacao.BuscadoresPalavras;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests.BuscadoresPalavras
{
    public class BuscadorPalavraEsquerdaParaDireitaTests
    {
        private readonly BuscadorPalavraEsquerdaParaDireita _buscador;

        public BuscadorPalavraEsquerdaParaDireitaTests()
        {
            var matriz = new MatrizLetras().Matriz;
            _buscador = new BuscadorPalavraEsquerdaParaDireita(matriz);
        }

        [Fact]
        public void Deve_encontrar_uma_palavra_no_sentido_esquerda_para_direita()
        {
            var palavra = "VETOR";

            var encontrouPalavra = _buscador.BuscarPalavra(palavra, 9, 0);

            encontrouPalavra.Should().BeTrue();
        }
    }
}