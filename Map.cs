using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public class Map
	{
		public int[,] board;

		Map(int nRows, int nCols)
		{
			board = new int[nRows, nCols];
		}

	}
}
