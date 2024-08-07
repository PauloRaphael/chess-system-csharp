﻿namespace tabuleiro
{
    internal abstract class Peca
    {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos {  get; set; }
        public Tabuleiro Tab {  get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Tab = tab;
            Cor = cor;
            Posicao = null;
            QteMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }
        public void DecrementarQteMovimentos()
        {
            QteMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
        
        public abstract bool[,] MovimentosPossiveis();
 
    } 
}