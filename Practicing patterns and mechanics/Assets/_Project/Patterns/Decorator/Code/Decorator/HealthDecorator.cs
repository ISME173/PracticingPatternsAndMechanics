public class HealthDecorator : HealthComponent
{
    protected HealthComponent _healthComponent;

    public HealthDecorator(HealthComponent healthComponent)
    {
        _healthComponent = healthComponent;
    }

    public override float GetHealth()
    {
        return _healthComponent.GetHealth();
    }
}
