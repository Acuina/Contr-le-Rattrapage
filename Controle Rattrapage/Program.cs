﻿using System;
using Controle_Rattrapage.Services;

namespace Controle_Rattrapage
{
    class Program
    {
        private static DemandeUsers _demandeUser = new DemandeUsers(); // utiliser les fonctions qui se trouve dans DemandeUsers
        private static ServicesJoueurs _ServicesJoueurs = new ServicesJoueurs(); // utiliser les fonctions qui se trouve dans ServicesJoueurs 
        static void Main(string[] args)
        {
            while (true)
            {
                string choixUsers = MenuGénéral();

                    if (choixUsers == "1")
                {
                    Console.WriteLine("Montrer la liste des joueurs: \n");
                    _ServicesJoueurs.AfficheJoueursdetennis();
                }
                    else if (choixUsers == "2")
                {
                    Console.WriteLine("blblblbl");
                }
                     else if (choixUsers == "3")
                {
                    Console.WriteLine("blblblbl");
                }
                     else if (choixUsers == "4")
                {
                    Console.WriteLine("blblblbl");
                }
                    else if (choixUsers == "5")
                {
                    Console.WriteLine("blblblbl");
                }
                    else if (choixUsers == "6")
                {
                    Console.WriteLine("blblblbl");
                }
                    else if (choixUsers == "7")
                {
                    Console.WriteLine("blblblbl");
                }
                    else if (choixUsers == "8")
                {
                    Console.WriteLine("blblblbl");
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
            Console.WriteLine("1 Montrer la liste des joueurs");
            Console.WriteLine("2 Montrer la liste des tournois\n");
            Console.WriteLine("3 Ajout d'un joueur à la liste");
            Console.WriteLine("4 Ajout d'un tournois à la liste");
            Console.WriteLine("5 Modifier la liste des joueurs\n");
            Console.WriteLine("6 Modifier la liste des tournois\n");
            Console.WriteLine("7 Supprimer un joueur de la liste des joueurs");
            Console.WriteLine("8 Supprimer un tournois de la liste des tournois\n");
            Console.WriteLine("Q Quitter l'application\n");
            string ChoixUser = _demandeUser.AppelduString("");
            return ChoixUser;
        }
    }
}