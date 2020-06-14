using System;
using System.Collections.Generic;
using System.Text;

namespace LifeOfAnts
{
	public class Queen : Ant
	{
        private static volatile Queen SoleInstance = new Queen();

        private Queen()
			:base()
		{

		}

        public static Queen GetInstance()
		{
            return SoleInstance;
		}
	}
}