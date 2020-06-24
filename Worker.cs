using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	class Worker:Ant, IMovable
	{

		public Worker(int x, int y, string[,] map) : base(x, y, map)
		{
			map[x, y] = "S";
		}

		public override (int, int) Move(string[,] map)
		{
			return (1, 1);
		}
	}
}
