using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public interface IFactionCollection
	{
		List<string> Friendlies { get; }
		List<string> Neutrals { get; }
		List<string> Hostiles { get; }
	}

	public class FactionCollection : IFactionCollection
	{
		public List<string> Friendlies { get; private set; } = new List<string>();
		public List<string> Neutrals { get; private set; } = new List<string>();
		public List<string> Hostiles{ get; private set; } = new List<string>();
	}

	public class Faction : IFactionCollection
	{
		private readonly static Dictionary<string, Faction> knownFactions = new Dictionary<string, Faction>();
		public static bool TryGetFaction (string name, out Faction result) {
			return knownFactions.TryGetValue(name, out result);
		}
		public IEnumerable<string> KnownFactionNames => knownFactions.Keys;
		public IDictionary<string, Faction> KnownFactions => knownFactions;

		public const string FactionPlayer = "Player";
		public const string FactionFriendly = "Friendly";
		public const string FactionNeutral = "Neutral";
		public const string FactionHostile = "Hostile";
		static Faction () {
			// Create default factions
			new Faction(FactionPlayer);
			new Faction(FactionFriendly);
			new Faction(FactionNeutral);
			new Faction(FactionHostile);
		}

		public bool DefaultHostile = false;

		public readonly string Name;
		private readonly FactionCollection Collection = new FactionCollection();

		public Faction (string name) {
			Name = name;
			if (Name != "")
				knownFactions[Name] = this;
		}

		public bool IsFriendly (Faction other) {
			if (this.Friendlies.Contains(other.Name) || other.Friendlies.Contains(Name))
				return true;
			if (this.Neutrals.Contains(other.Name) || other.Neutrals.Contains(Name))
				return true;
			if (this.Hostiles.Contains(other.Name) || other.Hostiles.Contains(Name))
				return false;
			return !DefaultHostile && !other.DefaultHostile;
		}

		public bool IsHostile (Faction other) {
			return !IsFriendly(other);
		}

		public List<string> Friendlies => this.Collection.Friendlies;

		public List<string> Neutrals => this.Collection.Neutrals;

		public List<string> Hostiles => this.Collection.Hostiles;

	}

}
