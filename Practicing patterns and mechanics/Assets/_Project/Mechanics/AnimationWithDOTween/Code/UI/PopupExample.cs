using UnityEngine;

public class PopupExample : MonoBehaviour
{
    [SerializeField] private Popup _popup;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _popup.gameObject.SetActive(true);
            _popup.Show();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _popup.Hide();
        }
    }
}
