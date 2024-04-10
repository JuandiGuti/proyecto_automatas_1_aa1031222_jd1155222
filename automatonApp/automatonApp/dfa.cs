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
using System.Text.RegularExpressions;
using static System.Windows.Forms.LinkLabel;

namespace automatonApp
{
	
	public partial class dfa : Form
	{
		// Lista global para almacenar la informacion del archivo
		public List<string> transitions = new List<string>();
		public int num_states;
		public string intial_state;
		public List<string> final_states = new List<string>();
		public int count = 0;
		public bool error = false;

		public dfa()
		{
			InitializeComponent();
		}
		//restablece todas las variables en memoria local
		public void restart()
		{
			transitions.Clear();
			final_states.Clear();
			count = 0;
		}
		//comprueba por medio de regex que lo leido en el archivo sea un numero
		public bool number_comprobation(string line)
		{
			bool isNumber = Regex.IsMatch(line, "^[1-9]+$");
			return isNumber;
		}
		//utiliza el metodo number_comprobation y agrega la variante del poder ser varios
		public void number_comprobation_final_states(string line)
		{
			final_states = line.Split(',').Select(num => num.Trim()).ToList();
		}
		//utiliza el metodo number_comprobation y agrega la variante de tener un simbolo
		public void transitions_comprobation()
		{

		}

		private void bt_open_file_Click(object sender, EventArgs e)
		{
			restart();
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
							switch(count){
								case 0://numero de estados
									if (number_comprobation(line))
									{
										num_states = int.Parse(line);
										count++;
									}
									else
									{
										restart();
										error = true;
										MessageBox.Show("The file is not valid.", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
									break;
								case 1://estado incial

									break;
								case 2://estados finales
									try
									{
										number_comprobation_final_states(line);
										count++;
									}
									catch (Exception a)
									{
										restart();
										error = true;
										MessageBox.Show("The file is not valid." + "\n Error code: " + a, "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
									break;
								default://transiciones
									transitions.Add(line);
									count++;
									break;
							}
						}
						file.Close();
					}
				}
				catch (Exception a)
				{
					Console.WriteLine("The file could not be read:");
					Console.WriteLine(a.Message);
				}
			}
		}

		private void dfa_Load(object sender, EventArgs e)
		{

		}
	}
}
