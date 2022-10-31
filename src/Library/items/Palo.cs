using System;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo. Permite atacar.
    /// </summary>
    public class Palo : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }
        public override string ToString()
        {
            return "Palo";
        }
    }
}