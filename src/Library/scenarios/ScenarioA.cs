using System;
using RoleplayGame.Characters;
using System.Collections.Generic;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
namespace RoleplayGame.Scenarios;

public class ScenarioA : IScenario
{
    List<Character> personajes = new List<Character>();
    public void Setup()
    {
        Elf p1 = new Elf("Santi");
        Trolls p2 = new Trolls("Coco");
        Wizard p3 = new Wizard("Sofi");
        Trolls p4 = new Trolls("Luis");

        List<IItem> itemsP1 = new List<IItem>() {new Espada(), new Coraza()};
        p1.AddItems(itemsP1);
        List<IItem> itemsP2 = new List<IItem>() {new HachaMedieval(), new Palo()};
        p2.AddItems(itemsP2);
        List<IItem> itemsP3 = new List<IItem>() {new Espada(), new Palo()};
        p3.AddItems(itemsP3);
        List<IItem> itemsP4 = new List<IItem>() {new HachaMedieval(), new Coraza()};
        p4.AddItems(itemsP4);

        personajes.Add(p1);
        personajes.Add(p2);
        personajes.Add(p3);
        personajes.Add(p4);
    }

    public void Run()
    {
        EncounterFactory.GetEncounter(EncounterType.Attack, personajes[0], personajes[1]).DoEncounter();
        EncounterFactory.GetEncounter(EncounterType.Attack, personajes[2], personajes[3]).DoEncounter();
        if (personajes[0].IsDead && personajes[2].IsDead)
        {
            EncounterFactory.GetEncounter(EncounterType.Attack, personajes[1], personajes[3]).DoEncounter();
            if (personajes[1].IsDead)
            {
                Console.WriteLine($"El ganador de la Tierra Media es: {personajes[1]}");
            }
        }
        else if (personajes[1].IsDead && personajes[3].IsDead)
        {
            EncounterFactory.GetEncounter(EncounterType.Attack, personajes[0], personajes[2]).DoEncounter();
        }
    }
}