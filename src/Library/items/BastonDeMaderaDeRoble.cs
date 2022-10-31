using System;
namespace RoleplayGame.Items;

/// <summary>
/// Baston de madera. Permite atacar.
/// </summary>
public class BastonDeMaderaDeRoble : IAttackItem
{
    public int AttackPower
    {
        get
        {
            return 60;
        }
    }
} 