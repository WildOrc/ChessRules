namespace ChessRules
{
    class Board
    {
        public string fen { get; private set; }
        Figure[,] figures;
        public Color moveColor { get; private set; }


        public Board(string fen)
        {
            this.fen = fen;
            figures = new Figure[8, 8];
            Init();
        }

        public Board Move(FigureMoving fm)
        {
            Board next = new Board(fen);
            next.SetFigureAt(fm.from, Figure.none);
            next.SetFigureAt(fm.to, fm.figure);
            next.moveColor = moveColor.FlipColor();
            return next;
        }

        public Figure GetFigureAt(Square square)
        {
            if (square.OnBoard())
                return figures[square.x, square.y];
            return Figure.none;
        }

        void SetFigureAt(Square square, Figure figure)
        {
            if (square.OnBoard())
                figures[square.x, square.y] = figure;
        }

        void Init()
        {
            SetFigureAt(new Square("a1"), Figure.whiteKing);
            SetFigureAt(new Square("h8"), Figure.blackKing);
            moveColor = Color.white;
        }
    }
}
