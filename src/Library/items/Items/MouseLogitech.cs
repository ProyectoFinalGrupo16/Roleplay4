namespace RoleplayGame.Items;
/// <summary>
/// Clase que contiene el item más roto del juego. Un mouse logitech azul
/// </summary>
public class MouseLogitech : IAttackItem , IDefenseItem
{
    private Magic magia;
    public int AttackPower
    {
        get
        {
            return magia.AttackPower+20;
        }
    }
    public int DefensePower
    {
        get
        {
            return magia.DefensePower+20;
        }
    }
    public override string ToString()
    {
        return "MouseLogitech";
    }

}