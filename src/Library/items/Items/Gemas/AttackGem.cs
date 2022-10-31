namespace RoleplayGame.Items;
/// <summary>
/// Clase que contiene las gemas de poder
/// </summary>
public abstract class AttackGem : IGem
{
    private Magic magia;
    public int AttackPower
    {
        get
        {
            return magia.AttackPower;
        }
    }
    public int DefensePower
    {
        get
        {
            return 0;
        }
    }
    public override string ToString()
    {
        return "Attack Gem";
    }

}