using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeCore;

namespace TictacToeCore.Test
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void Test_CellInitallyEmpty()
        {
            Cell cell = new Cell();
            Assert.AreEqual<bool>(true,cell.isEmpty());

        }
        [TestMethod]
        public void Test_CellGettingMarked()
        {
            Cell cell = new Cell();
            cell.MarkCell(MarkType.X);
            Assert.AreEqual(MarkType.X, cell.Mark);
        }
        [TestMethod]

        public void Test_CellGettingMarkedTwice()
        {
            Cell cell = new Cell();
            cell.MarkCell(MarkType.X);
            try
            {
                cell.MarkCell(MarkType.O);
                Assert.Fail();
            }
            catch(Exception)
            {
                

            }
        }
    }
}
