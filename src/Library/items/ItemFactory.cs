namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Magic = 1,
        Robes = 2,

        Arco= 3,
        BastonDeMaderaDeRoble=4,
        BastonMagico=5,
        Coraza=6,
        EscudoMagico=7,

        EscudoMedieval=8,
        Espada=9,
    
        GemaMagica=11,
        GuanteDePoder=12,
        HachaMedieval=13,
        Palo=14,
        PaloMagico=15,
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Magic: return new Magic();
                case ItemType.Robes: return new Robes();
                case ItemType.Arco: return new Arco();
                case ItemType.BastonDeMaderaDeRoble: return new BastonDeMaderaDeRoble();
                case ItemType.BastonMagico: return new BastonMagico(new Magic(),new GemaDePoder());
                case ItemType.Coraza: return new Coraza();
                case ItemType.EscudoMagico: return new EscudoMagico(new EscudoMedieval(),new GemaMagicaDefensa());
                case ItemType.EscudoMedieval: return new EscudoMedieval();
                case ItemType.Espada: return new Espada();
                case ItemType.GemaMagica: return new GemaMagicaDefensa();
                case ItemType.GuanteDePoder: return new GuanteDePoder();
                case ItemType.HachaMedieval: return new HachaMedieval();
                case ItemType.Palo: return new Palo();
                case ItemType.PaloMagico: return new PaloMagico();
                



                default: return null;
            }
        }
    }
}