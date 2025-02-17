using UnityEngine;

public abstract class BonusInteractable : MonoBehaviour
{
    protected abstract void AddBonusToPlayer(PlayerHealth playerHealth);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerHealth playerHealth))
        {
            AddBonusToPlayer(playerHealth);
            Destroy(gameObject);
        }
    }
}
