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
using TavernTales.Interface.Controls;

namespace TavernTales.Interface
{
	public partial class CombatForm : Form
	{
		private Party party = new Party();

		public CombatForm() {
			InitializeComponent();

			Player testPlayer1 = new Player("Daedalus", "Fighter", Faction.FactionPlayer);
			Player testPlayer2 = new Player("Sarissa", "Priest", Faction.FactionPlayer);

			testPlayer1.Abilities.Strength.Value = 16;
			testPlayer1.Abilities.Intelligence.Value = 4;
			testPlayer1.Abilities.Health.Value = 20;
			testPlayer1.Abilities.Health.BaseValue = 20;

			testPlayer2.Abilities.Wisdom.Value = 14;
			testPlayer2.Abilities.Constitution.Value = 16;
			testPlayer2.Abilities.Charisma.Value = 8;
			testPlayer2.Abilities.Intelligence.Value = 8;
			testPlayer2.Abilities.Strength.Value = 4;

			party[testPlayer1.Name] = testPlayer1;
			party[testPlayer2.Name] = testPlayer2;

			UpdateParty();
		}

		private void UpdateParty() {
			PartyPanel.Controls.Clear();
			foreach(Player player in party) {
				PlayerControl pControl = new PlayerControl(player);
				PartyPanel.Controls.Add(pControl);
			}
		}
	}
}
