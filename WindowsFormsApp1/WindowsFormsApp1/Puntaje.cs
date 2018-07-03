using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Puntaje
    {
        public string nombre { get; set; }

        public int puntaje { get; set; }

        public string Display
        {
            get
            {
                return string.Format(nombre, puntaje);
            }
        }

    }
}
