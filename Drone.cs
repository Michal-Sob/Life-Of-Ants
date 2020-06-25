using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	class Drone:Ant, IMovable
	{


		public Drone(int x, int y, Map map) : base(x, y, map)
		{
			_x = x;
			_y = y;

			Program.AllMovables.Add(this);

			map.Board[x, y] = "D";
		}

		private int _matingCounter = 0;

		public override void Move(Map map)
		{
			int queenX = Queen.GetInstance().X;
			int queenY = Queen.GetInstance().Y;
			Queen queen = Queen.GetInstance();

			map.Board[_x, _y] = "O";

			if (QueenDistance() == 3)
			{
				if (queen.Mood())
				{
					Mating();
				}
				else
				{
					_x = 1;
					_y = 1;
				}

				map.Board[_x, _y] = "D";

				return;
			}

			if (queenX > _x && queenX - _x >= queenY - _y)  // to make the drone move vertical or horizontal depending on where it is further.
				_x++;

			else if (queenY > _y && queenX - _x <= queenY - _y)
				_y++;

			else if (queenX < _x && _x - queenX >= _y - queenY)
				_x--;

			else if (queenY < _y && _x - queenX < _y - queenY)
				_y--;

			map.Board[_x, _y] = "D";
		}

		public void Mating()
		{
			Random rnd = new Random();

			if (rnd.NextDouble() > 0.5)
			{
				_x = 1;
				_y = 1;
			}
			else
			{
				_x = 49;
				_y = 49;
			}
		}
	}
}
