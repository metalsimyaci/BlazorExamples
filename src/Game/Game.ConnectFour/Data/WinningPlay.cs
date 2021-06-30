using System.Collections.Generic;

namespace Game.ConnectFour.Data
{
    public class WinningPlay
    {
        public List<string> WinningMoves { get; set; }
        public EvaluationDirections WinningDirection { get; set; }
        public PieceColors WinningColor { get; set; }
    }
}
