using System;

namespace RoleplayGame.Items
{
    public class GemaMagicaDefensa : IDefenseItem
    {
        public int DefensePower
        {
            get
            {
                return 50;
            }
        }
    }
}