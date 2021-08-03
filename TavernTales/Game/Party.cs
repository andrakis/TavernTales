using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public class Party : IEnumerable<Player>
	{
		private readonly Dictionary<string, Player> players = new Dictionary<string, Player>();

		public Player this[string key] {
			get { return players[key]; }
			set { players[key] = value; }
		}

		public IEnumerator<Player> GetEnumerator() => players.Values.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => players.Values.GetEnumerator();
	}
}
