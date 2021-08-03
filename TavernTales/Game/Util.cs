using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{ 
	public static class Util
	{
		private readonly static Random rng = new Random();
		public static int GetRandomInt (int max = int.MaxValue, int min = int.MinValue) {
			return rng.Next(max, min);
		}

		public static int GetDiceRoll (int count, int value, int multiplier = 1) {
			int total = 0;
			for (int i = 0; i < count; ++i) {
				int roll = GetRandomInt(value, 0);
				Debug.WriteLine("  d{1} rolls for {2}", value, roll);
				total += roll;
			}
			Debug.WriteLine("{0}d{1} rolled for a combined total of {2}", count, value, total);
			return total * multiplier;
		}
	}
}
