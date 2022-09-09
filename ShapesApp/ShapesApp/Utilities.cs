using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesApp
{
    internal class Utilities
    {
        ///Raza pozitiva validare
        private bool RazaPozitiva(double raza)
        {
            if(raza > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///Validare daca circleCode are 3 litere
        public static bool validareCircleCode(string circleCode)
        {
            foreach (char c in circleCode)
            {
                if (c < '0' || c > '4')
                {
                    return false;
                }
            }
            return true;
        }

        ///Validare isCharactersOnly
        /*private static bool isCharactersOnly(string circleCode)
        {
            if(validareCircleCode(circleCode))
            {

            }
        }*/
    }
}
