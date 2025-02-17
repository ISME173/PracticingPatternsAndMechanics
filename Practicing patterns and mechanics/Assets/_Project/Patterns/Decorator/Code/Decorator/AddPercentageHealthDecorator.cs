public class AddPercentageHealthDecorator : HealthDecorator
{
    private readonly float _percentageHealthToAdd;

    public AddPercentageHealthDecorator(HealthComponent healthComponent, float percentageHealthToAdd) : base(healthComponent)
    {
        _percentageHealthToAdd = percentageHealthToAdd;
    }

    public override float GetHealth()
    {
        float percentageBonus = (_healthComponent.GetHealth() / 100) * _percentageHealthToAdd;
        return _healthComponent.GetHealth() + percentageBonus;
    }
}
