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

		public mainForm() {

			InitializeComponent();

			this.BackColor = Color.Red;
		}

		private void ChangeColorButton_Click(object sender, EventArgs e) {

			ChooseColorForm chooseColor = new ChooseColorForm();

			chooseColor.SelectedColor = this.BackColor;

			chooseColor.OnColorUpdate += UpdateColor;

			chooseColor.Show();
		}

		private void UpdateColor(Color selectedColor) {

			this.BackColor = selectedColor;
		}
	}
}
