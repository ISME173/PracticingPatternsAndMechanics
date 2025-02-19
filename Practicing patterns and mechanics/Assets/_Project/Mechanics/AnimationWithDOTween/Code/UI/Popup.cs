using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Popup : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private RectTransform _body;
    [SerializeField] private Button _click;

    private Vector2 _targetBodyPosition;
    private Vector2 _targetShift;
    private Sequence _animation;

    private void Start()
    {
        _targetBodyPosition = _body.position;
        _targetShift = new Vector2(_targetBodyPosition.x, -Screen.height / 2);
    }

    public void Show()
    {
        if (_animation != null && _animation.active)
            _animation.Kill();

        _animation = DOTween.Sequence();

        _animation
            .Append(_canvasGroup.DOFade(1, 1).From(0))
            .Join(_body.DOAnchorPos(_targetBodyPosition, 1).From(_targetShift))
            .Append(_click.transform.DOScale(1, 0.5f).From(0).SetEase(Ease.OutBounce));
    }
    public void Hide()
    {
        if (_animation != null && _animation.active)
            _animation.Kill();

        _animation = DOTween.Sequence();

        _animation
            .Append(_canvasGroup.DOFade(0, 1).From(1))
            .Join(_body.DOAnchorPos(_targetShift, 1).From(_targetBodyPosition))
            .OnComplete(() => gameObject.SetActive(false));
    }
}
