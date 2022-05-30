using System;
using System.Collections.Generic;
using System.Text;

namespace Greta202201.Modeles
{
    public class Personnage
    {
        #region Attributs
        private string _nom;
        private string _arme;
        private int _vie;
        private int _force;
        #endregion

        #region Constructeurs
        public Personnage(string nom, string arme, int vie, int force)
        {
            _nom = nom;
            _arme = arme;
            _vie = vie;
            _force = force;
        }

        #endregion

        #region Getter/Setter
        public string Nom { get => _nom; set => _nom = value; }
        public string Arme { get => _arme; set => _arme = value; }
        public int Vie { get => _vie; set => _vie = value; }
        public int Force { get => _force; set => _force = value; }
        #endregion

        #region
        #endregion
    }
}
