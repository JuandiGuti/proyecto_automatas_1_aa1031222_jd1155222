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
	public partial class home : Form
	{
		public home()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Crear una nueva instancia del segundo formulario
			Form dfa = new dfa();

			// Mostrar el segundo formulario
			dfa.Show();

			// Esconder y no cerrar debidio a que es el formulario principal
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
            // Crear una nueva instancia del segundo formulario
            Form ndfa = new ndfa();

            // Mostrar el segundo formulario
            ndfa.Show();

            // Esconder y no cerrar debidio a que es el formulario principal
            this.Hide();
        }

		private void home_Load(object sender, EventArgs e)
		{

		}
	}
}
