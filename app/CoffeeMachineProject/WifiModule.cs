namespace CoffeeMachineProject
{
    public class WifiModule : ICoffeeMachineFeature
    {
        public CoffeeMachineFeatureType FeatureType
        {
            get { return CoffeeMachineFeatureType.WifiModule; }
        }

        public void Operate()
        {
            Console.WriteLine("Reordering coffee using WiFi.");
        }
    }
}