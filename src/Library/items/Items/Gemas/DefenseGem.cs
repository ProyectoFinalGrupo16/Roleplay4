namespace RoleplayGame.Items;
/// <summary>
/// Clase que contiene las gemas de poder
/// </summary>
public abstract class DefenseGem : IGem
{
    private Magic magia;
    public int AttackPower
    {
        get
        {
            return 0;
        }
    }
    public int DefensePower
    {
        get
        {
            return magia.DefensePower;
        }
    }
    public override string ToString()
    {
        return "Defense Gem";
    }

}