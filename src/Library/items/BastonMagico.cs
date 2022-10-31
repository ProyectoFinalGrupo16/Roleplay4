using System.Globalization;
using System;
namespace RoleplayGame.Items;

/// <summary>
/// Baston mágico. Permite atacar.
/// </summary>
public class BastonMagico : IAttackItem
{
    private GemaDePoder Gema {get; set;}
    private Magic Magic {get; set;}

    public BastonMagico(Magic magic, GemaDePoder gema)
    {
        this.Magic = magic;
        this.Gema = gema;
    }
    public int AttackPower
    {
        get
        {
            return Gema.valorDeGema + Magic.AttackPower;
        }
    }
}