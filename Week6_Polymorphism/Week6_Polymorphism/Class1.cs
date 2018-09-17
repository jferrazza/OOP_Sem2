using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_Polymorphism
{
    abstract public class Weapon
    {

        public int BaseDamage { get; protected set; }
        public int BaseRange { get; protected set; }
        public int CriticalDamage { get; protected set; }
        public int ActionPoints { get; protected set; }

        virtual public int Hit() { throw new NotImplementedException(); }

        public Weapon(int baseDamage, int baseRange, int criticalDamage)
        {
            BaseDamage = baseDamage;
            BaseRange = baseRange;
            CriticalDamage = criticalDamage;
            ActionPoints = 0;
        }
    }


    public class Malee : Weapon
    {
        public Malee(int baseDamage, int baseRange, int criticalDamage) : base(baseDamage, baseRange, criticalDamage) { }

        public override int Hit()
        {
            var r = new Random();
            ActionPoints++;
            return r.Next(100) < 10 ? CriticalDamage : BaseDamage;
        }

    }
    public class Range : Weapon
    {
        public Range(int baseDamage, int baseRange, int criticalDamage) : base(baseDamage, baseRange, criticalDamage) { }

        public override int Hit()
        {
            var r = new Random();
            var rr = r.Next(100) < 5;
            if (rr) ActionPoints++;
            return rr ? CriticalDamage : BaseDamage;
        }

    }
}
