using DG.Tweening;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _positionZ;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    private int _repeats = -1;

    private void Start()
    {
        transform.DOMoveZ(_positionZ, _duration).SetLoops(_repeats, _loopType);
    }
}
