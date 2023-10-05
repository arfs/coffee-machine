using CoffeeMachineProject;

class Program
{
    static void Main(string[] args)
    {
        var factory = new CoffeeMachineFactory();
        var fancyCoffeeMachine = factory.Create(CoffeeMachineFeatureType.Grinder | CoffeeMachineFeatureType.WifiModule);

        fancyCoffeeMachine.BrewCoffee();

        var grinder = fancyCoffeeMachine.GetFeatureByType(CoffeeMachineFeatureType.Grinder);
        grinder?.Operate();

        var wifiModule = fancyCoffeeMachine.GetFeatureByType(CoffeeMachineFeatureType.WifiModule);
        wifiModule?.Operate();
    }
}
