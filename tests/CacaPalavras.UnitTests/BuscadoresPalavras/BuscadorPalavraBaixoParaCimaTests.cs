using CacaPalavras.Aplicacao;
using CacaPalavras.Aplicacao.BuscadoresPalavras;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests.BuscadoresPalavras
{
    public class BuscadorPalavraBaixoParaCimaTests
    {
        private readonly BuscadorPalavraBaixoParaCima _buscador;

        public BuscadorPalavraBaixoParaCimaTests()
        {
            var matriz = new MatrizLetras().Matriz;
            _buscador = new BuscadorPalavraBaixoParaCima(matriz);
        }

        [Fact]
        public void Deve_encontrar_uma_palavra_no_sentido_baixo_para_cima()
        {
            var palavra = "CLASSE";

            var encontrouPalavra = _buscador.BuscarPalavra(palavra, 8, 3);

            encontrouPalavra.Should().BeTrue();
        }
    }
}