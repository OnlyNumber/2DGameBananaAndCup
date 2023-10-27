using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinsController : MonoBehaviour
{
    [SerializeField]
    private SceneController _sceneController;


    [SerializeField]
    private TMP_Text _coinsText;

    public Action OnCoinsChange;

    [SerializeField]
    private int _coins;

    public int Coins
    {
        get
        {
            return _coins;
        }
        set
        {
            _coins = value;
            OnCoinsChange?.Invoke();
        }

    }

    private void Start()
    {
        _sceneController.OnSceneLoad += SaveCoins;


        if(_coinsText != null)
        {
            OnCoinsChange += ChangeCoinsText;
        }

        Coins = PlayerPrefs.GetInt(StaticFields.SAVE_COINS, Coins);
    }

    public void DoubleCoins()
    {
        Coins = 2 * Coins;
    }

    private void SaveCoins()
    {
        PlayerPrefs.SetInt(StaticFields.SAVE_COINS, Coins);
    }

    private void ChangeCoinsText()
    {
        _coinsText.text = _coins.ToString();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt(StaticFields.SAVE_COINS, _coins);
    }


}
