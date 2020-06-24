using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public abstract class Ant
	{
		private int _x;
		private int _y;

		public readonly int X;
		public readonly int Y;

		protected Ant(int x, int y, string[,] map)
		{
			_x = x;
			_y = y;

			map[x, y] = "A";
		}

		public virtual (int, int) Move(string[,] map)
		{
			Random rnd = new Random();

			map[_x, _y] = "O";

			_x = _x + rnd.Next(-1, 2);
			_y = _y + rnd.Next(-1, 2);

			map[_x, _y] = "A";

			return (_x, _y);
			
		}

		public virtual int QueenDistance()
		{
			int queenX = Queen.GetInstance().X;
			int queenY = Queen.GetInstance().Y;

			return Math.Abs(_x - queenX) + Math.Abs(_y - queenY);
		}
	}
}
