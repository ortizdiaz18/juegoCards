using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    internal class Equip : Card
    {
        private string targetAttribute;
        private int effectPoints;
        private string affinity;

        public string TargetAttribute { get => targetAttribute; set => targetAttribute = value; }
        public int EffectPoints { get => effectPoints; set => effectPoints = value; }
        public string Affinity { get => affinity; set => affinity = value; }

        
    }
}
