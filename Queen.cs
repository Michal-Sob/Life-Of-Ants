using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public class Queen
	{

		public readonly int X;
		public readonly int Y;

        private static volatile Queen SoleInstance = new Queen(25, 25);

        private Queen(int x, int y)
		{
			X = x;
			Y = y;
		}

        public static Queen GetInstance()
		{
            return SoleInstance;
		}

		public bool Mood()
		{



			return true;
		}
	}
}