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

		public ChooseColorForm() {

			InitializeComponent();
		}

		private void OkButton_Click(object sender, EventArgs e) {

			this.Close();
		}
	}
}
