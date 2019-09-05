﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeless_Dialog_Box {

	public partial class ChooseColorForm : Form {

		public delegate void UpdateColor(Color selectedColor);
		public event UpdateColor OnColorUpdate;

		private Color selectedColor;

		public Color SelectedColor {

			get {

				return selectedColor;
			}

			set {

				if (value == Color.Red) {

					redRadioButton.Select();
				} else if (value == Color.Green) {

					greenRadioButton.Select();
				} else if (value == Color.Blue) {

					blueRadioButton.Select();
				} else {

					// TODO
				}

				selectedColor = value;

				if (OnColorUpdate == null) {

					return;
				}

				OnColorUpdate(selectedColor);
			}
		}

		public ChooseColorForm() {

			InitializeComponent();
		}

		private void OkButton_Click(object sender, EventArgs e) {

			this.Close();
		}

		private void RedRadioButton_Click(object sender, EventArgs e) {

			SelectedColor = Color.Red;
		}

		private void GreenRadioButton_Click(object sender, EventArgs e) {

			SelectedColor = Color.Green;
		}

		private void BlueRadioButton_Click(object sender, EventArgs e) {

			SelectedColor = Color.Blue;
		}
	}
}
