namespace Modeless_Dialog_Box {
	partial class mainForm {
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
			this.changeColorButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// changeColorButton
			// 
			this.changeColorButton.Location = new System.Drawing.Point(189, 153);
			this.changeColorButton.Name = "changeColorButton";
			this.changeColorButton.Size = new System.Drawing.Size(121, 23);
			this.changeColorButton.TabIndex = 0;
			this.changeColorButton.Text = "Change Color";
			this.changeColorButton.UseVisualStyleBackColor = true;
			this.changeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 344);
			this.Controls.Add(this.changeColorButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "mainForm";
			this.Text = "Change Colors";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button changeColorButton;
	}
}

