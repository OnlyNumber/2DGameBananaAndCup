using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MovePanel : MonoBehaviour
{
    [SerializeField]
    private RectTransform _panelTransform;

    [SerializeField]
    private float _changeDuration;

    [SerializeField]
    private Direction _direction;

    [ContextMenu("ChangePosition")]
    private void ChangePosition(Direction _direction)
    {
        Debug.Log(gameObject.name +" "+ _direction);

        switch(_direction)
        {
            

            case Direction.left:
                {
                    //Debug.Log(_panelTransform.rect.width + "+" + _panelTransform.anchoredPosition.x);

                    _panelTransform.DOAnchorPos(new Vector2(-_panelTransform.rect.width + _panelTransform.anchoredPosition.x, _panelTransform.anchoredPosition.y), _changeDuration);
                    break;
                }

            case Direction.right:
                {
                    //Debug.Log(_panelTransform.rect.width +"+"+ _panelTransform.anchoredPosition.x);

                    _panelTransform.DOAnchorPos(new Vector2(_panelTransform.rect.width + _panelTransform.anchoredPosition.x,_panelTransform.anchoredPosition.y), _changeDuration);
                    break;
                }


        }
        
    }



    public void ChangePanelOnThatPanel(MovePanel panel)
    {
        Debug.Log("ChangePanel");

        ClosePanel();

        panel.ChangeMyPosition();


    }

    public void ChangeMyPosition() => ChangePosition(_direction);

    public void ClosePanel()
    {
        Direction oppositeDirection = _direction;

        if ((int)oppositeDirection + 2 < 4)
            oppositeDirection += 2;
        else
        {
            oppositeDirection -= 2;
        }

        ChangePosition(oppositeDirection);
    }

}

public enum Direction
{
    up,
    right,
    down,
    left
};