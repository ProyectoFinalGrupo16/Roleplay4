using System.Globalization;
using System;
namespace RoleplayGame.Items;

/// <summary>
/// Baston mágico. Permite atacar.
/// </summary>
public class BastonMagico : IAttackItem
{
    private IGem Gema {get; set;}
    private Magic Magic {get; set;}

    public BastonMagico(Magic magic, IGem gema)
    {
        this.Magic = magic;
        this.Gema = gema;
    }
    public int AttackPower
    {
        get
        {
            return Gema.AttackPower + Magic.AttackPower;
        }
    }
}