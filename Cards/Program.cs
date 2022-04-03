using Cards;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            


        }
        public bool generateCardCharacter(string name, string rarity, int costPoints, int attackPoints,
           int resistPoint, Equip equip, string affinity)
        {

            Character cardCharacter = new Character();
            cardCharacter.Name = name;
            cardCharacter.Rarity = rarity;
            cardCharacter.CostPoint = costPoints;
            cardCharacter.Affinity = affinity;
            cardCharacter.AttackPoints = attackPoints;
            cardCharacter.ResistPoints = resistPoint;
            cardCharacter.Equip = equip;

            return true;



        }
        public bool generateCardEquip( string name, string rarity, int costPoints, string targetAttribute,
            int effectPoints, string affinity)
        {
            Equip cardEquip = new Equip();
            cardEquip.Name = name;
            cardEquip.Rarity = rarity;
            cardEquip.CostPoint = costPoints;
            cardEquip.TargetAttribute = targetAttribute;
            cardEquip.EffectPoints = effectPoints;
            cardEquip.Affinity = affinity;
            return true;
        }
        public bool generateCardSupport( String name, string rarity, int costPoints, string effectType,
          int effectPoints)
        {
            SupportSkill cardSupport = new SupportSkill();
            cardSupport.Name = name;
            cardSupport.Rarity = rarity;
            cardSupport.EffectType = effectType;
            cardSupport.EffectPoints = effectPoints;
            return true;
        }

        public bool generateDeck()
        {

            return true;
        }



    }

}}