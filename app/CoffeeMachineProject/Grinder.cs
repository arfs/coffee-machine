namespace  CoffeeMachineProject 
{
    public class Grinder : ICoffeeMachineFeature
    {
        public CoffeeMachineFeatureType FeatureType
        {
            get { return CoffeeMachineFeatureType.Grinder; }
        }

        public void Operate()
        {
            Console.WriteLine("Grinding coffee beans.");
        }
    }
}