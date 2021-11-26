using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BarHandler : MonoBehaviour
{
    [SerializeField] private Slider _moneySlider = null;
    [SerializeField] private TMP_Text _moneyText = null;

    public void MoneySlider(float money)
    {
        _moneyText.text = "$ " + money.ToString("000 000 000");
    }

    public void SetSliderValue(bool isMax)
    {
        if (isMax) _moneySlider.value = _moneySlider.maxValue;
        else _moneySlider.value = _moneySlider.minValue;
    }
}
