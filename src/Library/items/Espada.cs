namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada. Permite atacar.
    /// </summary>
    public class Espada : IDefenseItem, IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 10;
            }
        }

        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 2;
            }
        }

        public override string ToString()
        {
            return "Espada";
        }
    }
}