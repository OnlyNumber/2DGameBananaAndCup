using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour
{
    [SerializeField]
    private SoundControl _soundControl;

    [SerializeField]
    private Sprite _switchOff;

    [SerializeField]
    private Sprite _switchOn;

    [SerializeField]
    private Button _button;
    

    private void Start()
    {


        ChangeImage();

        _soundControl.OnChangeVolume += ChangeImage;

    }

    public void ChangeImage()
    {
        if (_soundControl.IsMusic == 1)
        {
            _button.image.sprite = _switchOn;
        }
        else
        {
            _button.image.sprite = _switchOff;
        }
    }

}
