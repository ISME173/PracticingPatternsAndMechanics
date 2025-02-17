using UnityEngine;

public class AddPrecentageBonusInteractable :BonusInteractable
{
    [SerializeField, Min(0)] private float _healthToAddPrecentage = 50;

    protected override void AddBonusToPlayer(PlayerHealth playerHealth)
    {
        playerHealth.AddPercentageHealth(_healthToAddPrecentage);
    }
}
