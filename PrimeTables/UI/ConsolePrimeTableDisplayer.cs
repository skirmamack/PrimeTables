using System;

namespace PrimeTables.UI
{
    public class ConsolePrimeTableDisplayer
    {
        private readonly int _cellWidth;
        private readonly string _numberCellFormatString;

        public ConsolePrimeTableDisplayer(int cellTextIndent = Constants.General.DefaultCellTextIndent)
        {
            _cellWidth = cellTextIndent + 2;
            _numberCellFormatString = string.Format("{{0,{0}}} :", cellTextIndent);
        }


        public void Display(int[,] primeTable)
        {
            var colsRowsCount = GetPrimeTableColsRowsCount(primeTable);

            var rowText = new string('-', colsRowsCount * _cellWidth + 1);
            for (var rowIndex = 0; rowIndex < colsRowsCount; rowIndex++)
            {
                WriteLine(rowText);
                Write(":");

                DisplayRowCells(primeTable, colsRowsCount, rowIndex);

                Write("\n");
            }
            WriteLine(rowText);
        }

        private void DisplayRowCells(int[,] primeTable, int colsRowsCount, int row)
        {
            for (var col = 0; col < colsRowsCount; col++)
            {
                var number = (row == 0 && col == 0) ? null : (long?) primeTable[row, col];
                Console.Write(_numberCellFormatString, number);
            }
        }

        private static int GetPrimeTableColsRowsCount(int[,] primeTable)
        {
            var colsRowsCount = primeTable.GetUpperBound(1) + 1;
            if (colsRowsCount > Constants.General.MaxPrimeNumbersToDisplay + 1)
            {
                colsRowsCount = Constants.General.MaxPrimeNumbersToDisplay + 1;
            }
            return colsRowsCount;
        }

        private static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        private static void Write(string text)
        {
            Console.Write(text);
        }
    }
}
