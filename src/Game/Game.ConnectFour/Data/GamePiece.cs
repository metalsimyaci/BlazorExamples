namespace Game.ConnectFour.Data
{
    public class GamePiece
    {
        public PieceColors Color;

        public GamePiece()
        {
            Color = PieceColors.Blank;
        }

        public GamePiece(PieceColors color)
        {
            Color = color;
        }
    }
}
