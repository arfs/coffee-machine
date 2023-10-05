namespace CoffeeMachineProject 
{
    public class CoffeeMachine
    {
        private List<ICoffeeMachineFeature> _features { get; } = new List<ICoffeeMachineFeature>();

        public void AddFeature(ICoffeeMachineFeature feature)
        {
            _features.Add(feature);
        }

        public void BrewCoffee()
        {
            Console.WriteLine("Brewing coffee.");
        }

        public ICoffeeMachineFeature? GetFeatureByType(CoffeeMachineFeatureType feature)
        {
            return _features.FirstOrDefault(f => f.FeatureType.Equals(feature));
        }
    }
}