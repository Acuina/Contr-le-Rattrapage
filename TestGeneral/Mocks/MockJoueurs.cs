using System;
using System.Collections.Generic;
using System.Text;
using Controle_Rattrapage.Models;
using Controle_Rattrapage.Services;

namespace TestGeneral.Mocks
{
    class MockJoueurs
    {
        private List<Joueursdetennis> _mockjoueursdetennis;

        public override List<Joueursdetennis> getAll()
        {
            if (_mockjoueursdetennis == null)
            {
                _mockjoueursdetennis = new List<Joueursdetennis>();
                _mockjoueursdetennis.Add(new Joueursdetennis() { nom = "Smart", prénom = "iona", classements = 5 });
            }
            return _mockjoueursdetennis;
        }
    }
}
