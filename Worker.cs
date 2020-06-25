using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	class Worker : Ant, IMovable
	{
		//private int _x;
		//private int _y;

		public Worker(int x, int y, Map map) : base(x, y, map)
		{
			_x = x;
			_y = y;

			Program.AllMovables.Add(this);

			map.Board[x, y] = "W";
		}

		public override void Move(Map map)
		{
			Random rnd = new Random();

			map.Board[_x, _y] = "O";

			int randomMove = rnd.Next(-1, 1);

			if (randomMove == 0)
				_x += rnd.Next(-1, 2);
			else
				_y += rnd.Next(-1, 2);

			if (_x < 0 && _x > map.Width && _y > 0 && _y > map.Height)
				return;

			map.Board[_x, _y] = "W";
		}
	}
}
