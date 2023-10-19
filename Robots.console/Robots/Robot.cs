using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Robot
    {
        protected string nom;
        protected int positionX;
        protected int positionY;

        #region constructeur
        public Robot (string unNom, int unePositionX, int unePositionY)
        {
            this.nom = unNom;
            this.positionX = unePositionX;
            this.positionY = unePositionY;
        }
        #endregion

        public void avancer (int directionX, int directionY)
        {
            this.positionX = positionX + directionX;
            this.positionY = positionY + directionY;
        }

        public virtual string afficherPosition()
        {
            string result = "La position est : x = " + positionX + " y = " + positionY;
            return result;
        }
    }
}
