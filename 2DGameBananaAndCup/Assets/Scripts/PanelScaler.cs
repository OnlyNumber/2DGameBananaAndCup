using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PanelScaler : MonoBehaviour
{
    [SerializeField]
    private RectTransform _panelTransform;

    public void ScalePanel(float scale, float timeForScale)
    {
        _panelTransform.DOScale(scale, timeForScale);
    }

}
