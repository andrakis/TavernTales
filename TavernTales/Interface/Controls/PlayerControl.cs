using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TavernTales.Game;

namespace TavernTales.Interface.Controls
{
	public partial class PlayerControl : UserControl
	{
		private readonly Player player;

		public PlayerControl() : this(null) { }
		public PlayerControl(Player player = null) {
			InitializeComponent();
			this.player = player;
			UpdateDisplay();
		}

		public void UpdateDisplay() {
			AbilityScoreList.Items.Clear();

			if (player != null) {
				NameLabel.Text = player.Name;
				ArchetypeLabel.Text = player.Archetype;
				LevelLabel.Text = player.Abilities.Level.Value.ToString();
				StatusLabel.Text = player.Status;
				HitpointsLabel.Text = player.Abilities.Health.Value.ToString() + " / " + player.Abilities.Health.BaseValue.ToString();
				foreach (var kv in player.Abilities.SortedAbilities()) {
					// Skip Level and Health (already displayed)
					if (kv.Key == PlayerAbility.AbilityHealth ||
						kv.Key == PlayerAbility.AbilityLevel)
						continue;
					ListViewItem item = new ListViewItem(new string[] {
					kv.Key, kv.Value.Value.ToString(), kv.Value.Modifier.ToString()
				});
					AbilityScoreList.Items.Add(item);
				}
			}
		}
	}
}
