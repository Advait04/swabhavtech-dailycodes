﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCore
{
  public  class Board
    {
        private Cell[] _boardCells = new Cell[9];
        public Board()
        {
            for (int i = 0; i < _boardCells.Length; i++) 
                _boardCells[i] = new Cell();
        }
        public bool CheckBoardFull()
        {
            foreach (var cell in _boardCells) 
                if (cell.Mark == MarkType.EMPTY) return false;
            return true;
        }
        public Cell[] BoardCells
        { 
            get 
            { 
                return _boardCells;
            } 
        }
        public bool CheckBoardEmpty()
        {
            foreach (var cell in _boardCells) if (cell.Mark != MarkType.EMPTY) return false;
            return true;
        }

        public void MarkCellAtLocation(int location, MarkType mark)
        {
            _boardCells[location].MarkCell(mark);
        }
        public MarkType GetMark(int location)
        {
            return _boardCells[location].Mark;
        }
    }
}
