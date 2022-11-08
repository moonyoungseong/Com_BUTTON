using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList14 : MonoBehaviour
{
    public Text inputText14; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num14;

    public void ONE()
    {
        inputText14.text = recent.text + "1";
        recent.text = inputText14.text;
    }

    public void TWO()
    {
        inputText14.text = recent.text + "2";
        recent.text = inputText14.text;
    }

    public void THREE()
    {
        inputText14.text = recent.text + "3";
        recent.text = inputText14.text;
    }

    public void FOUR()
    {
        inputText14.text = recent.text + "4";
        recent.text = inputText14.text;
    }

    public void FIVE()
    {
        inputText14.text = recent.text + "1";
        recent.text = inputText14.text;
    }

    public void SIX()
    {
        inputText14.text = recent.text + "6";
        recent.text = inputText14.text;
    }

    public void SEVEN()
    {
        inputText14.text = recent.text + "7";
        recent.text = inputText14.text;
    }

    public void EIGHT()
    {
        inputText14.text = recent.text + "8";
        recent.text = inputText14.text;
    }

    public void NINE()
    {
        inputText14.text = recent.text + "9";
        recent.text = inputText14.text;
    }

    public void ZERO()
    {
        inputText14.text = recent.text + "0";
        recent.text = inputText14.text;
    }

    public void DELETE()
    {
        inputText14.text = null;
        user_num14 = 0;
    }

    public void CHECK()
    {
        user_num14 = Convert.ToInt32(inputText14.text);
    }
}
