namespace RoleplayGame.Items;
/// <summary>
/// Clase que contiene el item todavía más roto. Una espada de dragón con mango de mouse logitech
/// </summary>
public class LogitechDragonSword : IAttackItem , IDefenseItem
{
    private DragonSword espada;
    private MouseLogitech mouse;
    public int AttackPower
    {
        get
        {
            return espada.AttackPower+mouse.AttackPower;
        }
    }
    public int DefensePower
    {
        get
        {
            return mouse.DefensePower;
        }
    }
    public override string ToString()
    {
        return "Espada Logitech";
    }

}