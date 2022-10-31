using System;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Coraza. Permite defenderse levemente.
    /// </summary>
    public class Coraza : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 18;
            }
        }
        public override string ToString()
        {
            return "Coraza";
        }
    }
}