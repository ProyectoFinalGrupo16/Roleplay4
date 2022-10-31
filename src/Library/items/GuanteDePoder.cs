using System;
namespace RoleplayGame.Items;

public class GuanteDePoder : IAttackItem
{
    GemaDePoder gemaAzul = new GemaDePoder();
    GemaDePoder gemaRoja = new GemaDePoder();
    GemaDePoder gemaVerde = new GemaDePoder();

    public int AttackPower
    {
        get
        {
            return gemaAzul.valorDeGema + gemaRoja.valorDeGema + gemaVerde.valorDeGema;
        }
    }
}