using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void FixedUpdate()
    {
        var moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.Translate(moveDirection * (Time.deltaTime * _speed));
    }
}
