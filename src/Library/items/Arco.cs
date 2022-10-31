using System;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Arco. Permite atacar.
    /// </summary>
    public class Arco : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 90;
            }
        }
    }
}