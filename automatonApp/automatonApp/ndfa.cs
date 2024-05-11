using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace automatonApp
{
    public partial class ndfa : Form
    {
        // Lista global para almacenar la informacion del archivo
        public List<string> transitions = new List<string>();
        public int num_states;
        public string initial_state;
        public List<string> final_states = new List<string>();
        public int count = 0;
        public List<string> alphabet = new List<string>();

        public ndfa()
        {
            InitializeComponent();
        }

        private void ndfa_Load(object sender, EventArgs e)
        {

        }
        //restablece todas las variables en memoria local
        public void restart()
        {
            transitions.Clear();
            final_states.Clear();
            alphabet.Clear();
            count = 0;
            lb_status_automaton.Text = "Waiting for the automaton...";
            tb_string.ReadOnly = true;
            tb_string.Text = string.Empty;
            bt_sent_string.Enabled = false;

        }
        public List<string> get_alphabet(List<string> transitions)
        {

            List<string> alphabet = new List<string>();
            for (int i = 0; i < transitions.Count - 1; i++)
            {
                alphabet.Add(transitions[i].Split(',')[1].Trim());
            }
            HashSet<string> hashSet = new HashSet<string>(alphabet);
            alphabet = hashSet.ToList();
            return alphabet;
        }
        //comprueba por medio de regex que lo leido en el archivo sea un numero
        public bool number_comprobation(string line)
        {
            bool isNumber;
            isNumber = Regex.IsMatch(line, "^[0-9]+$");
            return isNumber;

        }
        //Agrega la variante del poder ser varios
        public void number_comprobation_final_states(string line)
        {
            final_states = line.Split(',').Select(num => num.Trim()).ToList();
        }
        //Comprobacion del formato de las transiciones
        public bool transitions_validations(List<string> transitions)
        {
            string actual_state, transition, state_to_reach;

            for (int i = 0; i < transitions.Count - 1; i++)
            {
                actual_state = transitions[i].Split(',')[0].Trim();
                transition = transitions[i].Split(',')[1].Trim();
                state_to_reach = transitions[i].Split(',')[2].Trim();
                if (actual_state.Equals("") || transition.Equals("") || state_to_reach.Equals("") || !number_comprobation(actual_state) || !number_comprobation(state_to_reach))
                {
                    return false;
                }
            }
            return true;
        }
        //Valida y compara que los estados se encuentren en las transiciones.
        public bool states_comprobation(List<string> transitions, string state)
        {
            string state_in_transition, state_in_transition2;
            for (int i = 0; i < transitions.Count - 1; i++)
            {
                state_in_transition = transitions[i].Split(',')[0].Trim();
                state_in_transition2 = transitions[i].Split(',')[2].Trim();
                if (state.Equals(state_in_transition) || state.Equals(state_in_transition2))
                {
                    return true;
                }
            }
            return false;
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
                            switch (count)
                            {
                                case 0://numero de estados
                                    if (number_comprobation(line))
                                    {
                                        num_states = int.Parse(line);
                                        count++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("The file is not valid.", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    break;
                                case 1://estado incial
                                    if (number_comprobation(line))
                                    {
                                        initial_state = line;
                                        count++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("The file is not valid.", "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                    break;

                                case 2://estados finales
                                    try
                                    {
                                        number_comprobation_final_states(line);
                                        count++;
                                    }
                                    catch (Exception a)
                                    {
                                        MessageBox.Show("The file is not valid." + "\n Error code: " + a, "Wrong Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
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
            if (!transitions_validations(transitions))
            {
                MessageBox.Show("The transitions in the file are not valid.", "Transition error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!states_comprobation(transitions, initial_state))
            {
                MessageBox.Show("The initial state in the file is not valid.", "State error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            alphabet = get_alphabet(transitions);
            lb_status_automaton.Text = "Automaton has been Loaded correctly!";
            tb_string.ReadOnly = false;
            bt_sent_string.Enabled = true;

        }

		private void bt_sent_string_Click(object sender, EventArgs e)
		{
            tb_results.Text = string.Empty;
			if (strings_validation(initial_state, transitions, tb_string.Text.Trim(), final_states, alphabet))
			{
				MessageBox.Show("The word is accepted", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("The word is not accepted", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		public bool strings_validation(string initial_state, List<string> transitions, string word, List<string> final_states, List<string> alphabet)
		{
			HashSet<string> current_states = new HashSet<string>();
			current_states.Add(initial_state);
			//current_states = epsilon_closure(); FALTA METODO EPSILON

			// Procesamos cada caracter de la palabra
			foreach (char symbol in word)
			{
				HashSet<string> next_states = new HashSet<string>();
				foreach (string state in current_states)
				{
					// Recorremos todas las transiciones para encontrar aquellas que corresponden al estado actual y al símbolo de entrada
					foreach (string transition in transitions)
					{
						string[] parts = transition.Split(',');
						if (parts[0].Trim() == state && parts[1].Trim() == symbol.ToString())
						{
							next_states.Add(parts[2].Trim());
							tb_results.AppendText(transition.Trim() + "\r\n");
						}
					}
				}
				// Obtener la cerradura epsilon de los siguientes estados, sin registrar las transiciones ε
				//current_states = epsilon_closure(); FALTA METODO EPSILON
			}

			// Comprobar si algún estado actual es un estado final
			foreach (string state in current_states)
			{
				if (final_states.Contains(state))
				{
					return true;
				}
			}
			return false;
		}




		private void button1_Click(object sender, EventArgs e)
		{
			// Crear una nueva instancia del segundo formulario
			Form home = new home();

			// Mostrar el segundo formulario
			home.Show();

			// Esconder y no cerrar debidio a que es el formulario principal
			this.Hide();
		}
	}
}
