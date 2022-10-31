using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Troll
    /// </summary>
    public class Trolls: Character
    {
        public Trolls(string name)
            : base(name)
        {
            this.Health = 60;
            this.AddItem(new Coraza());
            this.AddItem(new Palo());
        }
    }
}