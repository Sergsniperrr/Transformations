using UnityEngine;
using SplineMesh;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Spline _spline;
    [SerializeField] private float _speed;

    private float _splineRate = 0f;

    private void Update()
    {
        _splineRate += _speed * Time.deltaTime;

        if (_splineRate <= _spline.nodes.Count - 1)
            Place();
    }

    private void Place()
    {
        CurveSample sample = _spline.GetSample(_splineRate);

        transform.localPosition = sample.location;
        transform.localRotation = sample.Rotation;
    }
}
