using System;
using System.Collections.Generic;
using System.Timers;

namespace LifeOfAnts
{
	class Program
	{
		private static Map _map;

		public int Timestamp { get; private set; }
		public static List<IMovable> AllMovable = new List<IMovable>();


		static void Main(string[] args)
		{
			Random rnd = new Random();

			Map Map = new Map(50, 50);
			_map = Map;

			Queen Queen = Queen.GetInstance();

			Drone Drone1 = new Drone(rnd.Next(1, 50), rnd.Next(1, 50), _map.Board);
			AllMovable.Add(Drone1);

			Worker Worker1 = new Worker(rnd.Next(1, 50), rnd.Next(1, 50), _map.Board);
			AllMovable.Add(Worker1);

			SetTimer();

			Console.ReadLine();
			aTimer.Stop();
			aTimer.Dispose();




			for (int i = 0; i < 50; i++)
			{
				Console.Clear();

				Drone1.Move(Map.Board);

				Map.DisplayMap();

				System.Threading.Thread.Sleep(1000);
			}
		}

		private static Timer aTimer;

		public static void SetTimer()
		{
			int interval = 1000; // 1 sec
			aTimer = new Timer(interval);

			// Hook up the Elapsed event for the timer. 
			aTimer.Elapsed += OnTimedEvent;
			aTimer.AutoReset = true;
			aTimer.Enabled = true;
		}

		private static void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Console.Clear();
			Console.WriteLine("To quit press any key");

			foreach (IMovable ant in AllMovable)
			{
				ant.Move(_map.Board);
			}

			_map.DisplayMap();
		}
	}
}
