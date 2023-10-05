namespace CoffeeMachineProject
{
    public interface ICoffeeMachineFactory
    {
        CoffeeMachine Create(CoffeeMachineFeatureType features);
    }
}
