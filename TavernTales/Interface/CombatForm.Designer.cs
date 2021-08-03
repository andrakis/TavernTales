
namespace TavernTales.Interface
{
	partial class CombatForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.PartyPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// PartyPanel
			// 
			this.PartyPanel.Location = new System.Drawing.Point(12, 269);
			this.PartyPanel.Name = "PartyPanel";
			this.PartyPanel.Size = new System.Drawing.Size(861, 219);
			this.PartyPanel.TabIndex = 1;
			// 
			// CombatForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 500);
			this.Controls.Add(this.PartyPanel);
			this.Name = "CombatForm";
			this.Text = "CombatForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel PartyPanel;
	}
}