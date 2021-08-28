using System;

namespace CacaPalavras.Aplicacao
{
    /*
     * @author: Gustavo Baroni Bruder
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nCaça Palavras!\n");

            var matrizLetras = new MatrizLetras();
            matrizLetras.MostrarMapa();

            var palavras = new[]
            {
                "VETOR",
                "MAP",
                "ERRO",
                "IFELSE",
                "CLASSE",
                "WHILE",
            };
            Console.WriteLine($"\nPalavras para encontrar: {string.Join(", ",  palavras)}.\n");

            var matriz = matrizLetras.Matriz;
            var buscador = new BuscadorPalavra(matriz);

            foreach (var palavra in palavras)
            {
                var encontrouPalavra = buscador.BuscarPalavra(palavra);
                var mensagemPalavra = encontrouPalavra ? "foi encontrada" : "não foi encontrada";
                Console.WriteLine($"Palavra {palavra.PadRight(8)} {mensagemPalavra}.");
            }
        }
    }
}