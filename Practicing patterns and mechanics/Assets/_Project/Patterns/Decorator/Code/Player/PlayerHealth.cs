using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _startHealth;

    private HealthComponent _healthComponent;

    private HealthComponent HealthComponent
    {
        get => _healthComponent;
        set
        {
            _healthComponent = value;
            OnHealthChanged?.Invoke(GetHealthValue());
        }
    }

    public event Action<float> OnHealthChanged;

    private void Awake()
    {
        HealthComponent = new DeafultHealthComponent(_startHealth);
        OnHealthChanged?.Invoke(GetHealthValue());
    }
    private void Start()
    {
        OnHealthChanged?.Invoke(GetHealthValue());
    }

    public float GetHealthValue()
    {
        return HealthComponent.GetHealth();
    }

    public void AddPercentageHealth(float value)
    {
        HealthComponent = new AddPercentageHealthDecorator(HealthComponent, value);
    }

    public void AddFixedHealthCount(float value)
    {
        HealthComponent = new AddFixedHealthDecorator(HealthComponent, value);
    }
}
