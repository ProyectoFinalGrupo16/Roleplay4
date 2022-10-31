using System;

namespace RoleplayGame.Items
{
    public class EscudoMagico : IDefenseItem
    {
        private EscudoMedieval EscudoMedieval {get; set;}
        private GemaMagicaDefensa GemaMagicaDefensa {get; set;}

        public EscudoMagico(EscudoMedieval escudoMedieval, GemaMagicaDefensa gemaMagicaDefensa)
        {
            this.GemaMagicaDefensa = gemaMagicaDefensa;
            this.EscudoMedieval = escudoMedieval;
        }
        public int DefensePower
        {
            get
            {
                return EscudoMedieval.DefensePower + GemaMagicaDefensa.DefensePower;
            }
        }
    }
}