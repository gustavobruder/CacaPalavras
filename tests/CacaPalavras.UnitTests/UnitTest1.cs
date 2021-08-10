using CacaPalavras.Aplicacao;
using FluentAssertions;
using Xunit;

namespace CacaPalavras.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Deve_conseguir_encontrar_uma_palavra_no_sentido_esquerda_para_direita()
        {
            var palavras = "VETOR";

            var matrizLetra = new MatrizLetras();
            var matriz = matrizLetra.Matriz;

            var buscador = new BuscadorPalavra();
            var encontrouPalavra = buscador.BuscarPalavraEsquerdaParaDireita(matriz, palavras);

            encontrouPalavra.Should().BeTrue();
        }

        [Fact]
        public void Deve_conseguir_encontrar_uma_palavra_no_sentido_direita_para_esquerda()
        {
            var palavras = "MAP";

            var matrizLetra = new MatrizLetras();
            var matriz = matrizLetra.Matriz;

            var buscador = new BuscadorPalavra();
            var encontrouPalavra = buscador.BuscarPalavraDireitaParaEsquerda(matriz, palavras);

            encontrouPalavra.Should().BeTrue();
        }

        [Fact]
        public void Deve_conseguir_encontrar_uma_palavra_no_sentido_cima_para_baixo()
        {
            var palavras = "IFELSE";

            var matrizLetra = new MatrizLetras();
            var matriz = matrizLetra.Matriz;

            var buscador = new BuscadorPalavra();
            var encontrouPalavra = buscador.BuscarPalavraCimaParaBaixo(matriz, palavras);

            encontrouPalavra.Should().BeTrue();
        }

        [Fact]
        public void Deve_conseguir_encontrar_uma_palavra_no_sentido_baixo_para_cima()
        {
            var palavras = "CLASSE";

            var matrizLetra = new MatrizLetras();
            var matriz = matrizLetra.Matriz;

            var buscador = new BuscadorPalavra();
            var encontrouPalavra = buscador.BuscarPalavraBaixoParaCima(matriz, palavras);

            encontrouPalavra.Should().BeTrue();
        }
    }
}