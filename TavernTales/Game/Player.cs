using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public class PlayerAbility
	{
		public const string AbilityLevel = "Level";
		public const string AbilityHealth = "Health";
		public const string AbilityStrength = "Strength";
		public const string AbilityDexterity = "Dexterity";
		public const string AbilityConstitution = "Constitution";
		public const string AbilityIntelligence = "Intelligence";
		public const string AbilityWisdom = "Wisdom";
		public const string AbilityCharisma = "Charisma";
		public static readonly string[] Stats = {
			AbilityLevel, AbilityHealth, AbilityStrength,
			AbilityDexterity, AbilityConstitution,
			AbilityIntelligence, AbilityWisdom, AbilityCharisma
		};

		public int BaseValue;
		public int Value;
		public int Modifier;

		public PlayerAbility (int value, int modifier) {
			BaseValue = Value = value;
			Modifier = modifier;
		}
	}

	public class PlayerAbilityCollection {
		private readonly Dictionary<string, PlayerAbility> Collection = new Dictionary<string, PlayerAbility>();
		public PlayerAbilityCollection() {
			// Add all the stats
			Collection.Add(PlayerAbility.AbilityLevel, new PlayerAbility(1, 0));
			Collection.Add(PlayerAbility.AbilityHealth, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityStrength, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityDexterity, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityConstitution, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityIntelligence, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityWisdom, new PlayerAbility(10, 0));
			Collection.Add(PlayerAbility.AbilityCharisma, new PlayerAbility(10, 0));
		}

		public PlayerAbility Strength => Collection[PlayerAbility.AbilityStrength];
		public PlayerAbility Dexterity => Collection[PlayerAbility.AbilityDexterity];
		public PlayerAbility Constitution => Collection[PlayerAbility.AbilityConstitution];
		public PlayerAbility Intelligence => Collection[PlayerAbility.AbilityIntelligence];
		public PlayerAbility Wisdom => Collection[PlayerAbility.AbilityWisdom];
		public PlayerAbility Charisma => Collection[PlayerAbility.AbilityCharisma];
		public PlayerAbility Level => Collection[PlayerAbility.AbilityLevel];
		public PlayerAbility Health => Collection[PlayerAbility.AbilityHealth];

		public IEnumerable<KeyValuePair<string,PlayerAbility>> SortedAbilities() {
			List<KeyValuePair<string, PlayerAbility>> sorted = new List<KeyValuePair<string, PlayerAbility>>();
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityLevel, Collection[PlayerAbility.AbilityLevel]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityHealth, Collection[PlayerAbility.AbilityHealth]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityStrength, Collection[PlayerAbility.AbilityStrength]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityDexterity, Collection[PlayerAbility.AbilityDexterity]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityConstitution, Collection[PlayerAbility.AbilityConstitution]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityIntelligence, Collection[PlayerAbility.AbilityIntelligence]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityWisdom, Collection[PlayerAbility.AbilityWisdom]));
			sorted.Add(new KeyValuePair<string, PlayerAbility>(PlayerAbility.AbilityCharisma, Collection[PlayerAbility.AbilityCharisma]));
			var keys = sorted.Select(kv => kv.Key);
			var remaining = Collection.Keys.Where(k => keys.Contains(k) == false).OrderBy(k => k);
			foreach (string key in remaining)
				sorted.Add(new KeyValuePair<string, PlayerAbility>(key, Collection[key]));
			return sorted;
		}
	}

	public static class PlayerStatus
	{
		public const string StatusConcious = "Concious";
		public const string StatusUnconcious = "Unconcious";
		public const string StatusSleeping = "Sleeping";
		public const string StatusDead = "Dead";
	}

	public class Player
	{
		public string Name { get; private set; }
		public string Archetype { get; private set; }
		public PlayerAbilityCollection Abilities;
		public string FactionName { get; set; }
		public readonly Dictionary<string, Item> ItemsEquipped = new Dictionary<string, Item>();
		public readonly List<Item> ItemsCarried = new List<Item>();
		public string Status = PlayerStatus.StatusConcious;

		public Player (string name, string archetype, string faction) {
			Name = name;
			Archetype = archetype;
			FactionName = faction;
			Abilities = new PlayerAbilityCollection();
		}

		public bool IsFriendly (Player other) {
			Faction a, b;
			if (Faction.TryGetFaction(FactionName, out a) && Faction.TryGetFaction(other.FactionName, out b)) {
				return a.IsFriendly(b);
			}
			throw new NotImplementedException();
		}

		public bool IsHostile (Player other) {
			return !IsFriendly(other);
		}
	}

	public class NonPlayer : Player
	{
		public NonPlayer (string name, string archetype, string faction) : base(name, archetype, faction) {
		}
	}
}
