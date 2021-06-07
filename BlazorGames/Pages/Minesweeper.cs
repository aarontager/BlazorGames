using BlazorGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGames.Pages
{
    public partial class Minesweeper
    {
        private MinesweeperModel _model;

        private void StartGame(int size, int mines)
        {
            _model = new MinesweeperModel(size, mines);
        }
    }
}
