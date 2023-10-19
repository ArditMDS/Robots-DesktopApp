using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class RobotMobile : Robot
    {
        private int vitesse;
        public RobotMobile(string unNom, int unePositionX, int unePositionY, int uneVitesse) : base(unNom, unePositionX, unePositionY)
        {
            vitesse = uneVitesse;
        }

        public int CalculerDuréeDeDéplacement(int unePositionX, int unePositionY)
        {
            int distance = Math.Abs(unePositionX - positionX) + Math.Abs(unePositionY - positionY);
            int calcul = distance / vitesse;
            return calcul;
        }

        public override string afficherPosition()
        {
            string result = "La position est : x = " + positionX + " y = " + positionY + " avec une vitesse de :  " + vitesse;
            return result;
        }
    }
}
