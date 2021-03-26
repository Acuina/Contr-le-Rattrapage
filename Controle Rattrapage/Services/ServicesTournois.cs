using System;
using System.Collections.Generic;
using System.Text;
using Controle_Rattrapage.Models;

namespace Controle_Rattrapage.Services
{
    public class ServicesTournois
    {
        //declarations des variables
        private DemandeUsers _demandeUsers; 
        private ServicesJoueurs _servicesJoueurs;
        private List<tournois> Listedestournois = new List<tournois>();

        //injection de dépendances

        public ServicesTournois(DemandeUsers demandeUsers, ServicesJoueurs servicesJoueurs)
        {
            _demandeUsers = demandeUsers;
            _servicesJoueurs = servicesJoueurs;
        }

        public void Afficheuntournois()
        {
            foreach (tournois t in Listedestournois)
            {
                Console.WriteLine("Nom du tournoi :" + t.nom);
                Console.WriteLine("Vainqueur du tournoi :" + t.vainqueurdutournois.nom + " " + t.vainqueurdutournois.prénom);
            }
        }

        //ajout d'un tournois
        public void Creationdutournoi()
        {
            tournois t = new tournois(); //création d'un tournois
            int classementduvainqueur; // demande le classement du tournoi
            t.nom = _demandeUsers.AppelduString("Nom du tournoi: "); //demande le nom du tournois
            classementduvainqueur = _demandeUsers.DemandeEntier("Classement du vainqueur: "); //demande le classement du vainqueur du tournoi
            t.vainqueurdutournois = _servicesJoueurs.RechercherJoueurs(classementduvainqueur); // rechercher le gagnant du tournoi

            Listedestournois.Add(t);//ajout d'un tournois à la liste 
        }

        public void SupprimerTournoi()
        {
            tournois Supprimert = new tournois(); //ajout d'un tournoi
            string nomSupprimert; //Nom du tournoi
            nomSupprimert = _demandeUsers.AppelduString("Nom du tournoi à supprimer: "); 
            Supprimert = Afficheuntournois(nomSupprimert);
            Listedestournois.Remove(Supprimert); //suppression d'un tournoi

        }

        public tournois Afficheuntournois(string Affichenom)
        {
            tournois Affichet = new tournois();

            foreach(tournois t in Listedestournois)
            {
                if (t.nom == Affichenom)
                {
                    Affichet = t;
                    break;
                }
            }

            return Affichet;
        }

    }
}
