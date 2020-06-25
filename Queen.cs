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

		private bool _firstTime = true;
		private int _lastMating;

		public bool Mood()
		{
			int CurrentMating;

			if (_firstTime)
			{
				_firstTime = false;
				_lastMating = Program.Timestamp;
				return true;
			}

			CurrentMating = Program.Timestamp;

			return CurrentMating - _lastMating > 150 || CurrentMating - _lastMating < 10;
		}
	}
}