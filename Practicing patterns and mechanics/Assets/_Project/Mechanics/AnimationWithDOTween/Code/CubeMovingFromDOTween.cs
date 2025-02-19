using UnityEngine;
using DG.Tweening;

public class CubeMovingFromDOTween : MonoBehaviour
{
    [SerializeField] private float _movingTime;
    [SerializeField] private float _finalPositionX;

    private Tween _movingAnimation;
    private Tween _rotateAnimation;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _movingAnimation = transform.DOMoveX(_finalPositionX, _movingTime).From(0).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
            _rotateAnimation = transform.DORotate(new Vector3(0, 360, 0), 1, RotateMode.FastBeyond360).From(Vector3.up * 0).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
        }
        if (Input.GetKeyDown(KeyCode.E))
            KillAllAnimations();
    }
    private void KillAllAnimations()
    {
        _movingAnimation.Kill();
        _rotateAnimation.Kill();
    }
}
