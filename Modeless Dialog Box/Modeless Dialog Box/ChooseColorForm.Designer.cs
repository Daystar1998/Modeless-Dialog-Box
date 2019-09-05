namespace Modeless_Dialog_Box {
	partial class ChooseColorForm {
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
			this.redRadioButton = new System.Windows.Forms.RadioButton();
			this.greenRadioButton = new System.Windows.Forms.RadioButton();
			this.blueRadioButton = new System.Windows.Forms.RadioButton();
			this.okButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// redRadioButton
			// 
			this.redRadioButton.AutoSize = true;
			this.redRadioButton.Location = new System.Drawing.Point(12, 19);
			this.redRadioButton.Name = "redRadioButton";
			this.redRadioButton.Size = new System.Drawing.Size(45, 17);
			this.redRadioButton.TabIndex = 0;
			this.redRadioButton.TabStop = true;
			this.redRadioButton.Text = "Red";
			this.redRadioButton.UseVisualStyleBackColor = true;
			this.redRadioButton.Click += new System.EventHandler(this.RedRadioButton_Click);
			// 
			// greenRadioButton
			// 
			this.greenRadioButton.AutoSize = true;
			this.greenRadioButton.Location = new System.Drawing.Point(12, 42);
			this.greenRadioButton.Name = "greenRadioButton";
			this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
			this.greenRadioButton.TabIndex = 1;
			this.greenRadioButton.TabStop = true;
			this.greenRadioButton.Text = "Green";
			this.greenRadioButton.UseVisualStyleBackColor = true;
			this.greenRadioButton.Click += new System.EventHandler(this.GreenRadioButton_Click);
			// 
			// blueRadioButton
			// 
			this.blueRadioButton.AutoSize = true;
			this.blueRadioButton.Location = new System.Drawing.Point(12, 65);
			this.blueRadioButton.Name = "blueRadioButton";
			this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
			this.blueRadioButton.TabIndex = 2;
			this.blueRadioButton.TabStop = true;
			this.blueRadioButton.Text = "Blue";
			this.blueRadioButton.UseVisualStyleBackColor = true;
			this.blueRadioButton.Click += new System.EventHandler(this.BlueRadioButton_Click);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(63, 115);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// ChooseColorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(201, 150);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.blueRadioButton);
			this.Controls.Add(this.greenRadioButton);
			this.Controls.Add(this.redRadioButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "ChooseColorForm";
			this.Text = "Choose";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton redRadioButton;
		private System.Windows.Forms.RadioButton greenRadioButton;
		private System.Windows.Forms.RadioButton blueRadioButton;
		private System.Windows.Forms.Button okButton;
	}
}