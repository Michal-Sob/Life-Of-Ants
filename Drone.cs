using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	class Drone:Ant, IMovable
	{
		private int _x;
		private int _y;

		public Drone(int x, int y, string[,] map) : base(x, y, map)
		{
			_x = x;
			_y = y;

			map[x, y] = "D";
		}

		public override (int, int) Move(string[,] map)
		{
			int queenX = Queen.GetInstance().X;
			int queenY = Queen.GetInstance().Y;
			Queen queen = Queen.GetInstance();

			map[_x, _y] = "O";

			//if (QueenDistance() == 3 && queen.Mood())



			if (queenX > _x && queenX - _x >= queenY - _y)  // to make the drone move vertical or horizontal depending on where it is further.
				_x++;

			else if (queenY > _y && queenX - _x < queenY - _y)
				_y++;

			else if (queenX < _x && _x - queenX > _y - queenY)
				_x--;

			else if (queenY < _y && _x - queenX < _y - queenY)
				_y--;

			map[_x, _y] = "D";

			return (_x, _y);
		}

		public void Mating()
		{
			
		}
	}
}
