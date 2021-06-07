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
        private int _size;

        private void StartGame(int size, int mines)
        {
            _model = new MinesweeperModel(size, mines);
            _size = size;
        }

        private void Click(int row, int col)
        {
            _model.ClickTile(row, col);
        }

        private void Flag(int row, int col)
        {
            _model.Flag(row, col);
        }

        private string GetTile(int row, int col)
        {
            return _model.GetTile(row, col).ToString();
        }
    }
}
