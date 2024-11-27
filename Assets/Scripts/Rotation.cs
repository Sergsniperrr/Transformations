using DG.Tweening;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private LoopType _loopType;

    private int _repeats = -1;

    private void Start()
    {
        transform.DORotate(_endValue, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
