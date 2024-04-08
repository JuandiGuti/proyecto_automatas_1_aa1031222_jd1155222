using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automatonApp
{
	public partial class dfa : Form
	{
		public dfa()
		{
			InitializeComponent();
		}

		private void bt_open_file_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//aqui va el codigo para que el usuario selecione el archivo y obtenga la ruta
				String file_path = openFileDialog1.FileName;
			}
		}
	}
}
