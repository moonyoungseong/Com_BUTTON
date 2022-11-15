using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleSlider2 : MonoBehaviour
{
    private Slider scaleSlider2;

    public float scaleMinValue;
    public float scaleMaxValue;

    void Start()
    {
        scaleSlider2 = GameObject.Find("Slider2").GetComponent<Slider>();
        scaleSlider2.minValue = scaleMinValue;
        scaleSlider2.maxValue = scaleMaxValue;
        scaleSlider2.onValueChanged.AddListener(ScaleSliderUpdate);
    }

    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector2(value, value);
    }
}
