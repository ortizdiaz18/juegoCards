using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    internal class SupportSkill : Card
    {
        private string effectType;
        private int effectPoints;

        public string EffectType { get => effectType; set => effectType = value; }
        public int EffectPoints { get => effectPoints; set => effectPoints = value; }

       
      
    }
}
