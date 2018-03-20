namespace ChessRules
{
    struct Square
    {
        public static Square none = new Square(-1, -1);

        public int x { get; private set; }
        public int y { get; private set; }

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(string name) //e2, h8, g5
        {
            if (name.Length == 2 &&
                name[0] >= 'a' && name[0] <= 'h' &&
                name[1] >= '1' && name[1] <= '8')
            {
                x = name[0] - 'a';
                y = name[1] - '1';
            }
            else
                this = none;
        }

        public string Name
        {
            get
            {
                return ((char)('a' + x)).ToString() +
                       (y + 1).ToString(); 
            }
        }

        public bool OnBoard()
        {
            return (x >= 0 && x < 8) &&
                   (y >= 0 && y < 8);
        }
    }
}
