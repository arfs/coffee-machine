namespace CoffeeMachineProject
{
    public class CoffeeMachineFactory : ICoffeeMachineFactory 
    {
        public CoffeeMachine Create(CoffeeMachineFeatureType features)
        {
            var coffeeMachine = new CoffeeMachine();

            if(features.HasFlag(CoffeeMachineFeatureType.Grinder))
            {
                coffeeMachine.AddFeature(new Grinder());
            }

            if(features.HasFlag(CoffeeMachineFeatureType.Grinder))
            {
                coffeeMachine.AddFeature(new WifiModule());
            }

            return coffeeMachine;
        }
    }
}