using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	class Soldier : Ant, IMovable
	{
		//private int _x;
		//private int _y;

		public Soldier(int x, int y, Map map) : base(x, y, map)
		{
			_x = x;
			_y = y;

			Program.AllMovables.Add(this);

			map.Board[x, y] = "S";
		}

		private int _soldierTimeStamp = 1;

		public override void Move(Map map)
		{
			map.Board[_x, _y] = "O";

			if (_soldierTimeStamp == 5)
			{
				_soldierTimeStamp = 0;

			}
			Console.WriteLine(_soldierTimeStamp);

			if (_soldierTimeStamp == 4)
				_x--;

			else if (_soldierTimeStamp == 3)
				_y--;

			else if (_soldierTimeStamp == 2)
				_x++;

			else
				_y++;

			map.Board[_x, _y] = "S";

			_soldierTimeStamp++;
		}
	}
}
