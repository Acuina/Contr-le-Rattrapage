using System;
using System.Collections.Generic;
using System.Text;
using Controle_Rattrapage.Models;

namespace Controle_Rattrapage.Services
{
    public class ServicesJoueurs
    {
        private DemandeUsers _demandeUser;
        private List<Joueursdetennis> ListedesJoueur = new List<Joueursdetennis>(); //création d'une liste de type joueur

        public void AfficheJoueursdetennis()
        {
            //Affiche les infos des joueurs de tennis
            foreach (Joueursdetennis j in ListedesJoueur)
            {
                Console.WriteLine(j.nom);
                Console.WriteLine(j.prénom);
                Console.WriteLine(j.classements);
            }

        }

        public Joueursdetennis CreateJoueursdetennis()
        {
            //Ajout de la personne avec ses caracteristiques et ajout à la liste des joueurs
            Joueursdetennis jt = new Joueursdetennis();

            //demande le nom du joueur
            jt.nom = _demandeUser.AppelduString("Nom joueur");
            //demande le prénom du joueur
            jt.prénom = _demandeUser.AppelduString("Prénom joueur");
            //demande le classement du joueur
            jt.classements = _demandeUser.AppelduString("classement joueur");
            // Ajouter à la liste des joueurs
            ListedesJoueur.Add(jt);
            return jt;

        }
    }
}
