using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public class Map
	{
		public string[,] Board;
		public int Height { get; }
		public int Width { get; }

		public Map(int nRows, int nCols)
		{
			Board = new string[nRows, nCols];
			Height = nRows;
			Width = nCols;

			for (int x = 0; x < Board.GetLength(0); x++)
			{
				for (int y = 0; y < Board.GetLength(1); y++)
				{
					Board[x, y] = "O";
				}
			}

			Board[Height / 2, Width / 2] = "Q";
		}

		public void DisplayMap()
		{
			for (int i = 0; i < Board.GetLength(0); i++)
			{
				for (int j = 0; j < Board.GetLength(1); j++)
				{
					ColorLetters(Board[i, j]);

					Console.Write(Board[i, j]);
				}

				Console.WriteLine();
			}

		}

		private void ColorLetters(string cell)
		{
			if (cell == "A")
				Console.ForegroundColor = ConsoleColor.Yellow;

			else if (cell == "Q")
				Console.ForegroundColor = ConsoleColor.DarkRed;

			else if (cell == "W")
				Console.ForegroundColor = ConsoleColor.Green;

			else if (cell == "S")
				Console.ForegroundColor = ConsoleColor.Red;

			else if (cell == "D")
				Console.ForegroundColor = ConsoleColor.Magenta;

			else
				Console.ForegroundColor = ConsoleColor.White;
		}
	}
}