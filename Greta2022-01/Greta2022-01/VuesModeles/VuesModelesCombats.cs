using Greta202201.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Greta202201.VuesModeles
{
    public class VuesModelesCombats
    {
        
        
        public void CreerPersonnage()
        {
            Personnage P1 = new Personnage("hello world", "Massue", 80, 70);
            Personnage P2 = new Personnage("Bye world", "Revolver", 30, 40);
            //string leNom = P1.Nom;
            CasserLeMur(P1);
            CasserLeMur(P2);
        }

        public string CasserLeMur(Personnage param)
        {
            string Result = ""; // egal d'affectation
            //je verifie que le personnage a une massue
            if(param.Arme == "Massue") // egal de comparaison
            {
                Result = "J'ai une massue";
            }
            else
            {
                Result = " je n'ai pas de' massue";
            }
            //ensuite je casse le mur

            if( Result == "J'ai une massue")
            {
                Result = "le mur est detruit";
            }
            else
            {
                Result = "le mur est intact";
            }

            return Result;
        }
    }
}
