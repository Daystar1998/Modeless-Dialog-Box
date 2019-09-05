/*
 * Author: Matthew Day
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeless_Dialog_Box {

	public partial class mainForm : Form {

		ChooseColorForm chooseColor;

		public mainForm() {

			InitializeComponent();

			this.BackColor = Color.Red;
			this.chooseColor = null;
		}

		private void ChangeColorButton_Click(object sender, EventArgs e) {

			if (chooseColor == null) {

				chooseColor = new ChooseColorForm();

				chooseColor.FormClosed += ChooseColorForm_Close;

				chooseColor.SelectedColor = this.BackColor;

				chooseColor.OnColorUpdate += UpdateColor;

				chooseColor.Show();
			} else {

				chooseColor.Focus();
			}
		}

		private void UpdateColor(Color selectedColor) {

			this.BackColor = selectedColor;
		}

		private void ChooseColorForm_Close(object sender, EventArgs e) {

			chooseColor = null;
		}
	}
}
