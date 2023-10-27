using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationButton : MonoBehaviour
{
    [SerializeField]
    private RectTransform _buttonTransform;

    [SerializeField]
    private float _timeToScale;

    public void AnimateButton()
    {
        DOTween.Sequence()
            .Append(_buttonTransform.DOScale(0.8f, _timeToScale))
            .Append(_buttonTransform.DOScale(1f, _timeToScale));
    }

}
