using DG.Tweening;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _endValue;

    private void Start()
    {
        transform.DOScale(_endValue, _duration);
    }
}