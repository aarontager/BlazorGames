using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Models
{
    public class Tile
    {
        public int AdjacentMines { get; set; }
        public bool IsMine { get; set; }
        public bool IsFlagged { get; set; }
        public bool IsRevealed { get; set; }

        public Tile()
        {
            AdjacentMines = 0;
            IsMine = false;
            IsFlagged = false;
            IsRevealed = false;
        }

        public override String ToString()
        {
            if (IsFlagged)
                return "🚩";

            if (!IsRevealed)
                return "⬜";

            if (IsMine)
                return "💣";

            return AdjacentMines.ToString();
        }
    }
}
