namespace Game.ConnectFour.Data
{
    public class GameBoard
    {
        public GamePiece[,] Board { get; set; }

        public GameBoard()
        {
            Board = new GamePiece[Constants.DIMENSION_X, Constants.DIMENSION_Y];

            for (int i = 0; i < Constants.DIMENSION_X; i++)
            {
                for (int j = 0; j < Constants.DIMENSION_Y; j++)
                {
                    Board[i, j] = new GamePiece(PieceColors.Blank);
                }
            }
        }
    }
}
