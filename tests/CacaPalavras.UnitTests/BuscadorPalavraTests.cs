using CacaPalavras.Aplicacao;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests
{
    public class BuscadorPalavraTests
    {
        private readonly BuscadorPalavra _buscador;

        public BuscadorPalavraTests()
        {
            var matriz = new MatrizLetras().Matriz;
            _buscador = new BuscadorPalavra(matriz);
        }

        [Theory]
        [InlineData("VETOR")]
        [InlineData("MAP")]
        [InlineData("IFELSE")]
        [InlineData("CLASSE")]
        public void Deve_conseguir_encontrar_uma_palavra_na_matriz(string palavra)
        {
            var encontrouPalavra = _buscador.BuscarPalavra(palavra);

            encontrouPalavra.Should().BeTrue();
        }
    }
}