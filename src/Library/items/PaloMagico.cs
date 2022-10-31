namespace RoleplayGame.Items
{
    /// <summary>
    /// Palo Magico. Permite atacar y defender.
    /// </summary>
    public class PaloMagico : IAttackItem
    {
        private Magic magic { get; set;}
        private Espada espada {get; set;}
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return magic.AttackPower + espada.AttackPower;
            }
        }

        public override string ToString()
        {
            return "Palo Magico";
        }
    }
}