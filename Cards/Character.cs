using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
      class Character : Card
    {
        private int attackPoints;
        private int resistPoints;
        private Equip equip = new Equip();
        private string affinity;

       

        

        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public int ResistPoints { get => resistPoints; set => resistPoints = value; }
        public string Affinity { get => affinity; set => affinity = value; }
        internal Equip Equip { get => equip; set => equip = value; }

       

    }
}
