using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _view;
    [SerializeField] private float _duration;

    private string[] _text =
    {
        "Синий шар - движение. Зеленый куб - поворот. ",
        "Фиолетовая капсула - увеличение размера. ",
        "Красный куб - движение, поворот, увелич.размера. "
    };

    private int _index = -1;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        int loopsCount = -1;

        sequence.Append(_view.DOText(GetNextText(), _duration));
        sequence.Append(_view.DOText(GetNextText(), _duration).SetRelative());
        sequence.Append(_view.DOText(GetNextText(), _duration, true, ScrambleMode.All));
        sequence.SetLoops(loopsCount, LoopType.Restart);
    }

    private string GetNextText()
    {
        _index = ++_index % _text.Length;

        return _text[_index];
    }
}
