using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundControl : MonoBehaviour
{
    [SerializeField]
    private AudioSource _defaultMusic;

    [SerializeField]
    private SceneController _sceneController;

    public int IsMusic
    {
        get;

        private set;

    }

    public Action OnChangeVolume;

    private void Start()
    {
        IsMusic = PlayerPrefs.GetInt(StaticFields.SAVE_VOLUME);

        _sceneController.OnSceneLoad += SaveVolume;

        _defaultMusic.Play();

        _defaultMusic.volume = IsMusic;

    }

    public void SetMusicOpposite()
    {
        if (IsMusic == 1)
        {
            IsMusic = 0;
        }
        else
        {
            IsMusic = 1;
        }

        _defaultMusic.volume = IsMusic;

        OnChangeVolume?.Invoke();



    }

    public void SaveVolume()
    {
        PlayerPrefs.SetInt(StaticFields.SAVE_VOLUME, IsMusic);


    }

    private void OnApplicationQuit()
    {
        SaveVolume();
    }


}

