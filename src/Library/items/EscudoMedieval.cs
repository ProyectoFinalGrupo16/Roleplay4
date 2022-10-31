using System;

namespace RoleplayGame.Items
{
    public class EscudoMedieval : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 30;
            }
        }
    }
}