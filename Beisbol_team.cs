using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parley
{
    public class beisbol_team
    {
        private string nombre_club;
        private string ciudad;
        private string liga;
        private int? juegos_ganados;
        private int? juegos_perdidos;

        public string _nombre_club { get { return nombre_club; } set { nombre_club = value; } }
        public string _ciudad { get { return ciudad; } set { ciudad = value; } }
        public string _liga { get { return liga; } set { liga = value; } }
        public int? _juegos_ganados { get { return juegos_ganados; } set { juegos_ganados = value; } }
        public int? _juegos_perdidos { get { return juegos_perdidos; } set { juegos_perdidos = value; } }

        public beisbol_team()
        {
            _nombre_club = null;
            _ciudad = null; 
            liga = null;
            juegos_ganados = null;
            juegos_perdidos = null;
        }

    }
}
