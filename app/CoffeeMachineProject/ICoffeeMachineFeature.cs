namespace CoffeeMachineProject
{
    public interface ICoffeeMachineFeature
    {
        CoffeeMachineFeatureType FeatureType { get; }
        void Operate();
    }
}
