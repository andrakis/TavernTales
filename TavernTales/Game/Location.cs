using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public enum CardinalDirection
	{
		North,
		East,
		South,
		West,
		Up,
		Down
	}

	public class Location
	{
		private static readonly Dictionary<string, Location> knownLocations = new Dictionary<string, Location>();
		public bool TryGetLocation (string name, out Location result) {
			return knownLocations.TryGetValue(name, out result);
		}
		public IEnumerable<string> KnownLocationNames => knownLocations.Keys;
		public IDictionary<string, Location> KnownLocations => knownLocations;

		/// <summary>
		/// Unique ID
		/// </summary>
		public string Id { get; private set; }
		public string Name { get; set; }
		public string Description;
		public readonly Dictionary<string, Party> Parties = new Dictionary<string, Party>();
		public readonly Dictionary<string, NonPlayer> NonPlayers = new Dictionary<string, NonPlayer>();
		public readonly Dictionary<CardinalDirection, string> Exits = new Dictionary<CardinalDirection, string>();

		public Location(string id, string name) {
			Id = id;
			Name = name;
			if (Id != "")
				knownLocations[Id] = this;
		}

		public bool TryGetExit (CardinalDirection direction, out Location location) {
			string name;
			if (Exits.TryGetValue(direction, out name))
				return TryGetLocation(name, out location);
			location = default;
			return false;
		}
	}
}
