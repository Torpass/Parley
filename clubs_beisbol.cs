using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Parley
{
    public class Clubs
    {
        private List<beisbol_team> _clubs;

        public Clubs()
        {
            _clubs = new List<beisbol_team>();
        }


        public void Create(beisbol_team x)
        {
            _clubs.Add(x);
        }


        public void remove(string name)
        {
            beisbol_team auxiliar = new beisbol_team();

            foreach (beisbol_team team in _clubs)
            {
                if (team._nombre_club == name)
                {
                    auxiliar = team;
                    break;
                }
            }
            _clubs.Remove(auxiliar);
        }


        public void update(beisbol_team x)
        {
            foreach (beisbol_team auxiliar in _clubs)
            {
                if (auxiliar._nombre_club == x._nombre_club)
                {
                    auxiliar._nombre_club = x._nombre_club;
                    auxiliar._ciudad = x._ciudad;
                    auxiliar._liga = x._liga;
                    auxiliar._juegos_ganados = x._juegos_ganados;
                    auxiliar._juegos_perdidos = x._juegos_perdidos;
                    break;

                }
            }
        }

        public beisbol_team show(string name_club)
        {
            beisbol_team auxiliar = new beisbol_team();

            foreach (beisbol_team team in _clubs)
            {
                if (team._nombre_club == name_club)
                {
                    auxiliar._nombre_club = team._nombre_club;
                    auxiliar._ciudad = team._ciudad;
                    auxiliar._liga = team._liga;
                    auxiliar._juegos_ganados = team._juegos_ganados;
                    auxiliar._juegos_perdidos = team._juegos_perdidos;
                    break;
                }
            }
            return auxiliar;
        }


        public bool find(string club_name)
        {
            Boolean resp = false;
            foreach (beisbol_team team in _clubs)
            {
                if (team._nombre_club == club_name)
                {
                    resp = true;
                    break;
                }
            }
            return resp;
        }
    }
}
