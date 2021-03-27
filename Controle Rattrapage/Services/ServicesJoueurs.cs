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

        // définir le constructeur 
        public ServicesJoueurs(DemandeUsers demandeUsers)
        {
            _demandeUser = demandeUsers;
        }
        public void AfficheJoueursdetennis()
        {
            //Affiche les infos des joueurs de tennis
            foreach (Joueursdetennis j in ListedesJoueur)
            {
                Console.WriteLine("Nom: " + j.nom);
                Console.WriteLine("Prénom: " + j.prénom);
                Console.WriteLine("Classement: \n" + j.classements);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_- \n");
            }

        }


        public void Afficheunjoueur(Joueursdetennis j)
        {
                Console.WriteLine("Nom: " + j.nom);
                Console.WriteLine("Prénom: " + j.prénom);
                Console.WriteLine("Classement: " + j.classements);
                Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_- \n");
        }

        public Joueursdetennis CreateJoueursdetennis()
        {
            //Ajout de la personne avec ses caracteristiques et ajout à la liste des joueurs
            Joueursdetennis jt = new Joueursdetennis();

            //demande le nom du joueur
            jt.nom = _demandeUser.AppelduString("Nom du joueur");
            //demande le prénom du joueur
            jt.prénom = _demandeUser.AppelduString("Prénom du joueur");
            //demande le classement du joueur
            jt.classements = _demandeUser.DemandeEntier("classement du joueur");
            // Ajouter à la liste des joueurs
            ListedesJoueur.Add(jt);
            return jt;

        }

        public void SupprimerJoueurdetennis() //suppression des joueurs
        {
            int suppressionclassement = _demandeUser.DemandeEntier("Indiquez le classement du joueur a supprimer"); // demande du nombre
            Joueursdetennis j = new Joueursdetennis();
            j = RechercherJoueurs(suppressionclassement);
            ListedesJoueur.Remove(j);

            //Les lignes 59 à 61 remplace le foreach ( fonction plus courte et plus lisible ) et on va pouvoir appeller la fonction pour rechercher le joueur vainqueur
            
            /*foreach (Joueursdetennis jt in ListedesJoueur) // regarder sur chacun des joueurs 
            {
                if (jt.classements == suppressionclassement) 
                {
                    ListedesJoueur.Remove(jt);
                    break;
                }
            }*/
        }

        public void ModifierJoueurdetennis() //modifier des joueurs
        {
            int modifierclassement = _demandeUser.DemandeEntier("Indiquez le classement du joueur a modifier"); // demande du nombre
            Joueursdetennis j = new Joueursdetennis();
            j = RechercherJoueurs(modifierclassement);
            ListedesJoueur.Remove(j);

            //Les lignes 78 à 80 remplace le foreach ( fonction plus courte et plus lisible ) et on va pouvoir appeller la fonction pour rechercher le joueur vainqueur

            /*foreach (Joueursdetennis jm in ListedesJoueur) // regarder sur chacun des joueurs 
            {
                if (jm.classements == modifierclassement)
                {
                    j = jm; //stockage du joueur
                    ListedesJoueur.Remove(jm); //suppression du joueur
                    break;
                }
            } */

            Afficheunjoueur(j);
            CreateJoueursdetennis();
        }

        public Joueursdetennis RechercherJoueurs(int RechercheC)
        {
            Joueursdetennis RechercheJ = new Joueursdetennis();
            foreach (Joueursdetennis jt in ListedesJoueur)
            {
                if (jt.classements == RechercheC)
                {
                    RechercheJ = jt;
                    break;
                }
            }
            return RechercheJ;
        }
    }
}
