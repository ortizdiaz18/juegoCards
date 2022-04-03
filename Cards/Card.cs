using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        private string name;
        private string rarity;
        private int costPoint;

      

        public string Name { get => name; set => name = value; }
        public string Rarity { get => rarity; set => rarity = value; }
        public int CostPoint { get => costPoint; set => costPoint = value; }
    }
}
