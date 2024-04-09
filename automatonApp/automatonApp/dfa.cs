using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace automatonApp
{
	
	public partial class dfa : Form
	{
		// Lista global para almacenar la informacion del archivo
		public static List<string> datafile = new List<string>();
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
				try
				{
					// Utilizar streamreader para leer el archivo.
					using (StreamReader file = new StreamReader(file_path))
					{
						string line;
						// Leemos el archivo por linea.
						while ((line = file.ReadLine()) != null)
						{
							datafile.Add(line);
						}
					}
				}
				catch (Exception a)
				{
					Console.WriteLine("The file could not be read:");
					Console.WriteLine(a.Message);
				}


			}
		}
	}
}
