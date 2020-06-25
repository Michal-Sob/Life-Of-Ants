using System;
using System.Collections.Generic;
using System.Timers;

namespace LifeOfAnts
{
	class Program
	{
		private static Map _map;
		private static Timer aTimer;

		public static int Timestamp { get; private set; }
		public static List<IMovable> AllMovables = new List<IMovable>();

		static void Main(string[] args)
		{
			Random rnd = new Random();

			Map Map = new Map(50, 50);
			_map = Map;

			_ = new Drone(rnd.Next(1, 50), rnd.Next(1, 50), _map);
			_ = new Drone(rnd.Next(1, 50), rnd.Next(1, 50), _map);
			_ = new Worker(rnd.Next(1, 50), rnd.Next(1, 50), _map);
			_ = new Soldier(rnd.Next(1, 49), rnd.Next(1, 49), _map);

			SetTimer();

			Console.ReadLine();
			aTimer.Stop();
			aTimer.Dispose();

		}

		public static void SetTimer()
		{
			int interval = 1000; // 1 sec
			aTimer = new Timer(interval);

			// Hook up the Elapsed event for the timer. 
			aTimer.Elapsed += OnTimedEvent;
			aTimer.AutoReset = true;
			aTimer.Enabled = true;

			Timestamp = 0;
		}

		private static void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Timestamp++;

			Console.Clear();
			Console.WriteLine("Press Enter to quit");

			Console.WriteLine(source);
			foreach (IMovable ant in AllMovables)
			{
				ant.Move(_map);
			}

			_map.DisplayMap();
		}
	}
}
