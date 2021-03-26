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
                Console.WriteLine(j.nom);
                Console.WriteLine(j.prénom);
                Console.WriteLine(j.classements);
            }

        }


        public void Afficheunjoueur(Joueursdetennis j)
        {
                Console.WriteLine("Nom: " + j.nom);
                Console.WriteLine("Prénom: " + j.prénom);
                Console.WriteLine("Classement: " + j.classements);
                Console.WriteLine("\n");
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
            jt.classements = _demandeUser.DemandeEntier("classement joueur");
            // Ajouter à la liste des joueurs
            ListedesJoueur.Add(jt);
            return jt;

        }

        public void SupprimerJoueurdetennis() //suppression des joueurs
        {
            int suppressionclassement = _demandeUser.DemandeEntier("Indiquer le classement du joueur a supprimer"); // demande du nombre
            foreach (Joueursdetennis jt in ListedesJoueur) // regarder sur chacun des joueurs 
            {
                if (jt.classements == suppressionclassement) 
                {
                    ListedesJoueur.Remove(jt);
                    break;
                }
            }
        }

        public void ModifierJoueurdetennis() //modifier des joueurs
        {
            int modifierclassement = _demandeUser.DemandeEntier("Indiquer le classement du joueur a modifier"); // demande du nombre
            Joueursdetennis j = new Joueursdetennis();

            foreach (Joueursdetennis jm in ListedesJoueur) // regarder sur chacun des joueurs 
            {
                if (jm.classements == modifierclassement)
                {
                    j = jm; //stockage du joueur
                    ListedesJoueur.Remove(jm); //suppression du joueur
                    break;
                }
            }

            Afficheunjoueur(j);
            CreateJoueursdetennis();
        }

    }
}
