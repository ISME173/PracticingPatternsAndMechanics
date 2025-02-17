public class AddFixedHealthDecorator : HealthDecorator
{
    private float _fixedHealthToAdd;

    public AddFixedHealthDecorator(HealthComponent healthComponent, float fixedHealthToAdd) : base(healthComponent)
    {
        _fixedHealthToAdd = fixedHealthToAdd;
    }

    public override float GetHealth()
    {
        return _fixedHealthToAdd + _healthComponent.GetHealth();
    }
}
