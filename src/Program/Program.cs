using RoleplayGame.Scenarios;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IScenario scenarioA = new ScenarioA();
            scenarioA.Setup();
            scenarioA.Run();
        }
    }
}
