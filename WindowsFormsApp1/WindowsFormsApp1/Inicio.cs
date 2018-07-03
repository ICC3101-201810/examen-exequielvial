using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
    public partial class Inicio : Form
    {
        public List<Puntaje> puntajes;
        public Inicio()
        {

            puntajes = new List<Puntaje>();
            puntajes.Add(new Puntaje { nombre = "Chandler", puntaje = 500 });
            puntajes.Add(new Puntaje { nombre = "Monica", puntaje = 450 });
            puntajes.Add(new Puntaje { nombre = "Joey", puntaje = 420 });
            puntajes.Add(new Puntaje { nombre = "Phoebe", puntaje = 410 });
            puntajes.Add(new Puntaje { nombre = "Rachel", puntaje = 310 });
            puntajes.Add(new Puntaje { nombre = "Ross", puntaje = 300 });
            puntajes.Add(new Puntaje { nombre = "Gunther", puntaje = 290 });
            puntajes.Add(new Puntaje { nombre = "Paolo", puntaje = 250 });
            puntajes.Add(new Puntaje { nombre = "Fun Bobby", puntaje = 120 });
            puntajes.Add(new Puntaje{nombre = "Ugly naked guy", puntaje = 50});
            BinaryFormatter formattere = new BinaryFormatter();
            Stream miStreame = new FileStream("Puntajes.bin", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            formattere.Serialize(miStreame, puntajes);
            miStreame.Close();
            InitializeComponent();
            
            
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            this.Hide();
            Menu menu = new WindowsFormsApp1.Menu();
            menu.ShowDialog();
        }
    }
}
