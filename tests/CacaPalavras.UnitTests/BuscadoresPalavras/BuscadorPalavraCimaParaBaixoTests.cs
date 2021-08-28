using CacaPalavras.Aplicacao;
using CacaPalavras.Aplicacao.BuscadoresPalavras;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests.BuscadoresPalavras
{
    public class BuscadorPalavraCimaParaBaixoTests
    {
        private readonly BuscadorPalavraCimaParaBaixo _buscador;

        public BuscadorPalavraCimaParaBaixoTests()
        {
            var matriz = new MatrizLetras().Matriz;
            _buscador = new BuscadorPalavraCimaParaBaixo(matriz);
        }

        [Fact]
        public void Deve_encontrar_uma_palavra_no_sentido_cima_para_baixo()
        {
            var palavra = "IFELSE";

            var encontrouPalavra = _buscador.BuscarPalavra(palavra, 1, 0);

            encontrouPalavra.Should().BeTrue();
        }
    }
}