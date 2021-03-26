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

    }
}
