using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int _coins;

    public void AddCoin()
    {
        _coins+=1; 
        _text.text = _coins.ToString();
    }
}
