using UnityEngine;

public class AddFixedBonusInteractable : BonusInteractable
{
    [SerializeField] private float _healthToAdd;

    protected override void AddBonusToPlayer(PlayerHealth playerHealth)
    {
        playerHealth.AddFixedHealthCount(_healthToAdd);
    }
}
