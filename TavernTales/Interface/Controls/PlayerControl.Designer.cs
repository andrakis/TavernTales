
namespace TavernTales.Interface.Controls
{
	partial class PlayerControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.HitpointsLabel = new System.Windows.Forms.Label();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.NameLabel = new System.Windows.Forms.Label();
			this.ArchetypeLabel = new System.Windows.Forms.Label();
			this.StatusLabel = new System.Windows.Forms.Label();
			this.AbilityScoreList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// HitpointsLabel
			// 
			this.HitpointsLabel.AutoSize = true;
			this.HitpointsLabel.Location = new System.Drawing.Point(3, 28);
			this.HitpointsLabel.Name = "HitpointsLabel";
			this.HitpointsLabel.Size = new System.Drawing.Size(73, 17);
			this.HitpointsLabel.TabIndex = 3;
			this.HitpointsLabel.Text = "{Hitpoints}";
			// 
			// LevelLabel
			// 
			this.LevelLabel.AutoSize = true;
			this.LevelLabel.Location = new System.Drawing.Point(205, 28);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Size = new System.Drawing.Size(52, 17);
			this.LevelLabel.TabIndex = 4;
			this.LevelLabel.Text = "{Level}";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.NameLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.HitpointsLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LevelLabel, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.ArchetypeLabel, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.StatusLabel, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 56);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(3, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(55, 17);
			this.NameLabel.TabIndex = 1;
			this.NameLabel.Text = "{Name}";
			// 
			// ArchetypeLabel
			// 
			this.ArchetypeLabel.AutoSize = true;
			this.ArchetypeLabel.Location = new System.Drawing.Point(205, 0);
			this.ArchetypeLabel.Name = "ArchetypeLabel";
			this.ArchetypeLabel.Size = new System.Drawing.Size(82, 17);
			this.ArchetypeLabel.TabIndex = 3;
			this.ArchetypeLabel.Text = "{Archetype}";
			// 
			// StatusLabel
			// 
			this.StatusLabel.AutoSize = true;
			this.StatusLabel.Location = new System.Drawing.Point(104, 28);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(58, 17);
			this.StatusLabel.TabIndex = 5;
			this.StatusLabel.Text = "{Status}";
			// 
			// AbilityScoreList
			// 
			this.AbilityScoreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.AbilityScoreList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AbilityScoreList.HideSelection = false;
			this.AbilityScoreList.Location = new System.Drawing.Point(0, 56);
			this.AbilityScoreList.Name = "AbilityScoreList";
			this.AbilityScoreList.Size = new System.Drawing.Size(305, 170);
			this.AbilityScoreList.TabIndex = 6;
			this.AbilityScoreList.UseCompatibleStateImageBehavior = false;
			this.AbilityScoreList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ability";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Score";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Modifier";
			// 
			// PlayerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.AbilityScoreList);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PlayerControl";
			this.Size = new System.Drawing.Size(305, 226);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label HitpointsLabel;
		private System.Windows.Forms.Label LevelLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label ArchetypeLabel;
		private System.Windows.Forms.Label StatusLabel;
		private System.Windows.Forms.ListView AbilityScoreList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}
