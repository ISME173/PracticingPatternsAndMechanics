public class DeafultHealthComponent : HealthComponent
{
    private float _healthToAdd;

    public DeafultHealthComponent(float healthToAdd)
    {
        _healthToAdd = healthToAdd;
    }

    public override float GetHealth()
    {
        return _healthToAdd;
    }
}
