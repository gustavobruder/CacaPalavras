using System;
using CacaPalavras.Aplicacao.Extensions;

namespace CacaPalavras.Aplicacao
{
    public class MatrizLetras
    {
        private readonly short _quantidadeLinhas;
        private readonly short _quantidadeColunas;
        private readonly char[,] _matriz;

        public short QuantidadeLinhas => _quantidadeLinhas;
        public short QuantidadeColunas => _quantidadeColunas;
        public char[,] Matriz => _matriz;

        public MatrizLetras()
        {
            _quantidadeLinhas = 10;
            _quantidadeColunas = 5;
            _matriz = new char[_quantidadeLinhas, _quantidadeColunas];

            DefinirValoresMatriz();
        }

        private void DefinirValoresMatriz() {
            _matriz[0, 0]='R'; _matriz[0, 1]='A'; _matriz[0, 2]='P'; _matriz[0, 3]='A'; _matriz[0, 4]='M';
            _matriz[1, 0]='I'; _matriz[1, 1]='X'; _matriz[1, 2]='F'; _matriz[1, 3]='O'; _matriz[1, 4]='R';
            _matriz[2, 0]='F'; _matriz[2, 1]='F'; _matriz[2, 2]='R'; _matriz[2, 3]='G'; _matriz[2, 4]='F';
            _matriz[3, 0]='E'; _matriz[3, 1]='L'; _matriz[3, 2]='Y'; _matriz[3, 3]='E'; _matriz[3, 4]='W';
            _matriz[4, 0]='L'; _matriz[4, 1]='S'; _matriz[4, 2]='F'; _matriz[4, 3]='S'; _matriz[4, 4]='U';
            _matriz[5, 0]='S'; _matriz[5, 1]='D'; _matriz[5, 2]='G'; _matriz[5, 3]='S'; _matriz[5, 4]='S';
            _matriz[6, 0]='E'; _matriz[6, 1]='O'; _matriz[6, 2]='H'; _matriz[6, 3]='A'; _matriz[6, 4]='T';
            _matriz[7, 0]='A'; _matriz[7, 1]='K'; _matriz[7, 2]='U'; _matriz[7, 3]='L'; _matriz[7, 4]='G';
            _matriz[8, 0]='X'; _matriz[8, 1]='H'; _matriz[8, 2]='K'; _matriz[8, 3]='C'; _matriz[8, 4]='G';
            _matriz[9, 0]='V'; _matriz[9, 1]='E'; _matriz[9, 2]='T'; _matriz[9, 3]='O'; _matriz[9, 4]='R';
        }

        public void MostrarMapa()
        {
            for (var i = 0; i < _quantidadeLinhas; i++)
            {
                var linha = _matriz.GetRow(i);
                Console.WriteLine("--------------------");
                Console.WriteLine($"| {string.Join(" | ", linha)} |");
            }
            Console.WriteLine("--------------------");
        }
    }
}