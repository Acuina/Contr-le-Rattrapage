using System;
using Controle_Rattrapage.Services;

namespace Controle_Rattrapage
{
    class Program
    {
        private static DemandeUsers _demandeUser = new DemandeUsers(); // utiliser les fonctions qui se trouve dans DemandeUsers
        private static ServicesJoueurs _ServicesJoueurs = new ServicesJoueurs(_demandeUser); // utiliser les fonctions qui se trouve dans ServicesJoueurs 
        private static ServicesTournois _ServicesTournois = new ServicesTournois(_demandeUser, _ServicesJoueurs); // utiliser les fonctions qui se trouve dans ServicesTournois
        static void Main(string[] args)
        {
            while (true)
            {
                string choixUsers = MenuGénéral();

                    if (choixUsers == "1")
                {
                    Console.WriteLine("-_-_-_-_-_-_-_- Voici la liste des joueurs: -_-_-_-_-_-_-_- \n");
                    _ServicesJoueurs.AfficheJoueursdetennis();

                }
                    else if (choixUsers == "2")
                {
                    
                    Console.WriteLine("-_-_-_-_-_-_-_- Voici la liste des tournois: -_-_-_-_-_-_-_- ");
                    _ServicesTournois.Afficheuntournois();
                }
                     else if (choixUsers == "3")
                {
                    Console.WriteLine("-_-_-_-_-_-_-_- Joueur inscrits sur la liste: -_-_-_-_-_-_-_-");
                    _ServicesJoueurs.CreateJoueursdetennis();
                }
                     else if (choixUsers == "4")
                {
                    Console.WriteLine("-_-_-_-_-_-_-_- Tournois inscrits sur la liste: -_-_-_-_-_-_-_- ");
                    _ServicesTournois.Creationdutournoi();
                }
                    else if (choixUsers == "5")
                {
                    _ServicesJoueurs.ModifierJoueurdetennis();
                    Console.WriteLine("-_-_-_-_-_-_-_- Modifications de la liste des joueurs: -_-_-_-_-_-_-_- ");
                }
                    else if (choixUsers == "6")
                {
                    _ServicesTournois.Modificationtournoi();
                    Console.WriteLine("-_-_-_-_-_-_-_- Modifications de la liste des tournois: -_-_-_-_-_-_-_- ");
                }
                    else if (choixUsers == "7")
                {
                    _ServicesJoueurs.SupprimerJoueurdetennis();
                    Console.WriteLine("-_-_-_-_-_-_-_- Suppression d'un joueur de la liste des joueurs: -_-_-_-_-_-_-_- ");
                }
                    else if (choixUsers == "8")
                {
                    _ServicesTournois.SupprimerTournoi();
                    Console.WriteLine("-_-_-_-_-_-_-_- Suppression d'un tournois de la liste des tournois: -_-_-_-_-_-_-_- ");
                }
                else if (choixUsers == "Q")
                {
                    break;
                }
                    else
                {
                    Console.WriteLine("Je n'ai pas compris votre saisie veuillez recommencer");
                }
            }
        }
        private static string MenuGénéral()
            {
            Console.WriteLine("1 °° Montrer la liste des joueurs °°");
            Console.WriteLine("2 °° Montrer la liste des tournois °° \n");
            Console.WriteLine("3 °° Ajout d'un joueur à la liste °° ");
            Console.WriteLine("4 °° Ajout d'un tournois à la liste °° \n");
            Console.WriteLine("5 °° Modifier la liste des joueurs °° ");
            Console.WriteLine("6 °° Modifier la liste des tournois °° \n");
            Console.WriteLine("7 °° Supprimer un joueur de la liste des joueurs °° ");
            Console.WriteLine("8 °° Supprimer un tournois de la liste des tournois °° \n");
            Console.WriteLine("Q °° Quitter l'application °° \n");
            string ChoixUser = _demandeUser.AppelduString("");
            return ChoixUser;
        }
    }
}
