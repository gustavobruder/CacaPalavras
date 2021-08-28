using CacaPalavras.Aplicacao;
using CacaPalavras.Aplicacao.BuscadoresPalavras;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests.BuscadoresPalavras
{
    public class BuscadorPalavraDireitaParaEsquerdaTests
    {
        private readonly BuscadorPalavraDireitaParaEsquerda _buscador;

        public BuscadorPalavraDireitaParaEsquerdaTests()
        {
            var matriz = new MatrizLetras().Matriz;
            _buscador = new BuscadorPalavraDireitaParaEsquerda(matriz);
        }

        [Fact]
        public void Deve_encontrar_uma_palavra_no_sentido_direita_para_esquerda()
        {
            var palavra = "MAP";

            var encontrouPalavra = _buscador.BuscarPalavra(palavra, 0, 4);

            encontrouPalavra.Should().BeTrue();
        }
    }
}