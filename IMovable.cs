using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public interface IMovable
	{
		(int, int) Move(string[,] map);
	}
}
