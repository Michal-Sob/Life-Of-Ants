using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public abstract class Ant
	{
		protected int _x;
		protected int _y;
		public (int, int) Position { get => (_x, _y); }

		public readonly int X;
		public readonly int Y;

		protected Ant(int x, int y, Map map)
		{
			_x = x;
			_y = y;

			map.Board[x, y] = "A";
		}

		public virtual void Move(Map map)
		{
			Random rnd = new Random();

			map.Board[_x, _y] = "O";

			_x += + rnd.Next(-1, 2);
			_y += + rnd.Next(-1, 2);

			map.Board[_x, _y] = "A";
		}

		public int QueenDistance()
		{
			int queenX = Queen.GetInstance().X;
			int queenY = Queen.GetInstance().Y;
			Console.WriteLine(Math.Abs(_x - queenX) + Math.Abs(_y - queenY));
			return Math.Abs(_x - queenX) + Math.Abs(_y - queenY);
		}
	}
}
