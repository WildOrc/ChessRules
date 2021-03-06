﻿
namespace ChessRules
{
    enum Figure
    {
        none,

        whiteKing = 'K',
        whiteQueen = 'Q',
        whiteRook = 'R',
        whiteBishop = 'B',
        whiteKnight = 'N',
        whitePawn = 'P',

        blackKing = 'k',
        blackQueen = 'q',
        blackRook = 'r',
        blackBishop = 'b',
        blackKnight = 'n',
        blackPawn = 'p',



    }

    static class FigureMethods
    {
        public static Color GetColor(this Figure figure)
        {
            switch (figure)
            { 
                case Figure.whiteKing:
                case Figure.whiteQueen:
                case Figure.whiteRook:
                case Figure.whiteBishop:
                case Figure.whiteKnight:
                case Figure.whitePawn:
                    return Color.white;
                case Figure.blackKing:
                case Figure.blackQueen:
                case Figure.blackRook:
                case Figure.blackBishop:
                case Figure.blackKnight:
                case Figure.blackPawn:
                    return Color.black;
                default:
                    return Color.none;
            }
        }
    }
}
