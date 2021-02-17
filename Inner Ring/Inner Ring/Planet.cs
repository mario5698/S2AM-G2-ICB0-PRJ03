using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDades;

namespace Inner_Ring
{
    public partial class Planet : Form
    {
        DataTable planets;
        Dictionary<int, string> planetsDictionary = new Dictionary<int, string>();
        Acceso Acc = new Acceso();
        private static Random random = new Random();

        public Planet()
        {
            InitializeComponent();
            getAllPlanets();
        }

        private void getAllPlanets() {
             planets  = Acc.PortarTaula("Planets");
            for (int i = 0; i < planets.Rows.Count; i++)
            {
                int id =int.Parse( planets.Rows[i][0].ToString());
                string planetName= planets.Rows[i][2].ToString();
                planetsDictionary.Add(id, planetName);
                comboBox1.Items.Add(planetName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorRandom = RandomString(10);
            MessageBox.Show(valorRandom);
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
