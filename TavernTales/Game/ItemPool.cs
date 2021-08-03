using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernTales.Game
{
	public class ItemPoolFinalizedException : Exception
	{
		public ItemPoolFinalizedException (string name)
			: base("This item pool has already been finalized" + (name.Length == 0 ? "" : ": " + name)) {

		}
	}
	public class ItemPool
	{
		private static readonly Dictionary<string, ItemPool> knownPools = new Dictionary<string, ItemPool>();
		private readonly List<string> Inherits = new List<string>();
		private readonly List<Item> Items = new List<Item>();
		public bool Finalized { get; private set; } = false;

		public string Name { get; private set; } = "";
		public ItemPool (string name = "") {
			SetName(name);
		}

		public void Inherit (string name) {
			if (Finalized)
				throw new ItemPoolFinalizedException(Name);
			Inherits.Add(name);
		}

		public void AddItem (Item item) {
			if (Finalized)
				throw new ItemPoolFinalizedException(Name);
			Items.Add(item);
		}

		public void AddItems (IEnumerable<Item> items) {
			if (Finalized)
				throw new ItemPoolFinalizedException(Name);

			Items.AddRange(items);
		}

		public bool IsNameValid() {
			return IsNameValid(Name);
		}
		public bool IsNameValid(string name) {
			return name != "";
		}
		public void SetName (string name) {
			if (IsNameValid(Name))
				knownPools.Remove(Name);
			Name = name;
			if (IsNameValid(Name))
				knownPools[Name] = this;
		}

		private List<Item> ItemsFinalized;
		public string FinalizedBy = null;
		public List<Item> Finalize (string finalizedBy = null) {
			if (!Finalized) {
				Finalized = true;
				FinalizedBy = finalizedBy;
				ItemsFinalized = new List<Item>();
				foreach (string name in Inherits) {
					if (IsNameValid(name)) {
						ItemPool pool;
						if (knownPools.TryGetValue(name, out pool)) {
							ItemsFinalized.AddRange(pool.Finalize(Name));
						}
					}
				}
				ItemsFinalized.AddRange(Items);
			}
			return ItemsFinalized;
		}
	}
}
