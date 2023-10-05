using CoffeeMachineProject;

class Program
{
    static void Main(string[] args)
    {
        var factory = new CoffeeMachineFactory();
        CoffeeMachine fancyCoffeeMachine = factory.Create(CoffeeMachineFeatureType.Grinder | CoffeeMachineFeatureType.WifiModule);

        fancyCoffeeMachine.BrewCoffee();

        var grinder = fancyCoffeeMachine.GetFeatureByName(CoffeeMachineFeatureType.Grinder);
        grinder?.Operate();

        var wifiModule = fancyCoffeeMachine.GetFeatureByName(CoffeeMachineFeatureType.WifiModule);
        wifiModule?.Operate();
    }
}
