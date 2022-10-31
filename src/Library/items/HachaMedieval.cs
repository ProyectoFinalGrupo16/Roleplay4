namespace RoleplayGame.Items
{
    /// <summary>
    /// Hacha. Permite atacar.
    /// </summary>
    public class HachaMedieval : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 50;
            }
        }

        public override string ToString()
        {
            return "Hacha medieval";
        }
    }
}