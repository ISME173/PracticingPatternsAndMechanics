using TMPro;
using UnityEngine;

public class PlayerHealthView : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private TextMeshProUGUI _healthCountText;

    private void Awake()
    {
        _playerHealth.OnHealthChanged += DrawHealth;
    }

    private void DrawHealth(float health)
    {
        _healthCountText.text = $"Health count: {health}";
    }
}
