using System.Collections.Generic;
namespace RoleplayGame.Items;
/// <summary>
/// Clase que contiene el item más roto del juego. Un mouse logitech azul
/// </summary>
public class GuanteDePoder : IAttackItem , IDefenseItem
{
    private List<IGem> listaGemas = new List<IGem>();
    public int AttackPower
    {
        get
        {
            int ataquetotal = 0;
            foreach(var gema in listaGemas)
            {
                ataquetotal = ataquetotal+gema.AttackPower;
            }
            return ataquetotal;
        }
    }
    public int DefensePower
    {
        get
        {
            int defensatotal = 0;
            foreach(var gema in listaGemas)
            {
                defensatotal = defensatotal+gema.DefensePower;
            }
            return defensatotal;
        }
    }
    public void AddGem(IGem gema)
    {
        listaGemas.Add(gema);
    }
    public void RemoveGem(IGem gema)
    {
        listaGemas.Remove(gema);
    }
    public override string ToString()
    {
        return "Guante de Poder";
    }

}