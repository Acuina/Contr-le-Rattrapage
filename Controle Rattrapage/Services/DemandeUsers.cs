using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_Rattrapage.Services
{
    public class DemandeUsers
    {
        public string AppelduString(string message)
        {
            Console.WriteLine(message);                     // sert à afficher le message saisie
            string saisieUser = Console.ReadLine();  // Demande au clavier d'attendre à l'utilisateur la saisie 
            while (string.IsNullOrEmpty(saisieUser)) // sert à afficher le message saisie tant que la chaine est vide
            {
                Console.WriteLine("La saisie faite n'est pas bonne");
                saisieUser = Console.ReadLine();     // redemande la saisie
            }
            return saisieUser;                       // donne le resultat
        }

    }
}
