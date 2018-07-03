using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace WindowsFormsApp1
{
    

    public partial class Form1 : Form
    {
        BindingSource puntajesBinding = new BindingSource();
        public Form1()
        {
            List<Puntaje> puntajes = new List<Puntaje>();
            BinaryFormatter formatter1 = new BinaryFormatter();
            Stream mistreamc = new FileStream("puntajes.bin", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            if (mistreamc.Length != 0)
            {
                puntajes = (List<Puntaje>)formatter1.Deserialize(mistreamc);
            }
            mistreamc.Close();
            InitializeComponent();
            puntajesBinding.DataSource = puntajes;
            mostrar.DataSource = puntajesBinding;
            mostrar.ValueMember = "Display";
            mostrar.DisplayMember = "Display";
        }

        public void mostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
