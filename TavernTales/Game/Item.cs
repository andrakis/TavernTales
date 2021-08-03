using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public interface IStatModifier
	{
		int GetModifier();
	}
	public struct StraightStatModifier : IStatModifier
	{
		private readonly int Modifier;
		public StraightStatModifier (int modifier) {
			Modifier = modifier;
		}
		public int GetModifier () {
			return Modifier;
		}
		public override string ToString() =>
			(Modifier > 0 ? "+" : "") + Modifier.ToString();
	}
	public struct DiceRollModifier : IStatModifier
	{
		private readonly int DiceCount;
		private readonly int DiceValue;
		private readonly int Multiplier;

		public DiceRollModifier (int count, int value, int multiplier = 1) {
			DiceCount = count;
			DiceValue = value;
			Multiplier = multiplier;
		}

		public int GetModifier() => Util.GetDiceRoll(DiceCount, DiceValue, Multiplier);
		public override string ToString() =>
			String.Format("{0}{1}d{2}", (Multiplier > 0 ? "+" : ""), DiceCount, DiceValue);
	}

	public class ItemBonus
	{
		public readonly string BonusType;
		public readonly IStatModifier Modifier;
		public ItemBonus (string bonusType, IStatModifier modifier) {
			BonusType = bonusType;
			Modifier = modifier;
		}
		public override string ToString() => Modifier.ToString() + " " + BonusType;

		public static ItemBonus None = new ItemBonusNone();
	}

	public class ItemBonusNone : ItemBonus
	{
		public ItemBonusNone ()
			: base ("", new StraightStatModifier(0)) {
		}

		public override string ToString() => "";
	}

	public class ItemType
	{
		public const string TypeWeapon = "Weapon";
		public const string TypeArmor = "Armor";
		public const string TypeJewelry = "Jewelry";
	}

	public static class ItemSlot
	{
		public const string SlotHead = "Head";
		public const string SlotTorso = "Torso";
		public const string SlotRightHand = "RightHand";
		public const string SlotLeftHand = "LeftHand";
		public const string SlotForearms = "Forearms";
		public const string SlotHands = "Hands";
		public const string SlotWaist = "Waist";
		public const string SlotLegs = "Pants";
		public const string SlotFeet = "Feet";
		public const string SlotNeck = "Neck";
		public const string SlotRing1 = "Ring1";
		public const string SlotRing2 = "Ring2";
		public const string SlotRing3 = "Ring3";
		public const string SlotRing4 = "Ring4";
		public const string SlotRing5 = "Ring5";
		public const string SlotRing6 = "Ring6";
		public const string SlotRing7 = "Ring7";
		public const string SlotRing8 = "Ring8";
		public const string SlotRing9 = "Ring9";
		public const string SlotRing10 = "Ring10";
		public static readonly string[] Slots = {
			SlotHead, SlotTorso, SlotRightHand, SlotLeftHand,
			SlotForearms, SlotHands, SlotWaist, SlotLegs, SlotFeet,
			SlotNeck, SlotRing1, SlotRing2, SlotRing3, SlotRing4, SlotRing5,
			SlotRing6, SlotRing7, SlotRing8, SlotRing9, SlotRing1
		};
	}

	public class Item
	{
		private static readonly Dictionary<string, Item> knownItems = new Dictionary<string, Item>();
		public bool TryGetItem (string id, out Item result) {
			return knownItems.TryGetValue(id, out result);
		}

		/// <summary>
		/// Unique ID
		/// </summary>
		public readonly string ID;

		public string Name;
		public string Slot;
		public ItemBonus Bonus;

		public Item(string id, string slot, string name)
			: this(id, name, slot, ItemBonus.None) {
		}

		public Item (string id, string slot, string name, ItemBonus bonus) {
			ID = id;
			Slot = slot;
			Name = name;
			Bonus = bonus;
		}

	}
}
