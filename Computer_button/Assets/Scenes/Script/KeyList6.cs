using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList6 : MonoBehaviour
{
    public Text inputText6; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num6;

    public void ONE()
    {
        inputText6.text = recent.text + "1";
        recent.text = inputText6.text;
    }

    public void TWO()
    {
        inputText6.text = recent.text + "2";
        recent.text = inputText6.text;
    }

    public void THREE()
    {
        inputText6.text = recent.text + "3";
        recent.text = inputText6.text;
    }

    public void FOUR()
    {
        inputText6.text = recent.text + "4";
        recent.text = inputText6.text;
    }

    public void FIVE()
    {
        inputText6.text = recent.text + "1";
        recent.text = inputText6.text;
    }

    public void SIX()
    {
        inputText6.text = recent.text + "6";
        recent.text = inputText6.text;
    }

    public void SEVEN()
    {
        inputText6.text = recent.text + "7";
        recent.text = inputText6.text;
    }

    public void EIGHT()
    {
        inputText6.text = recent.text + "8";
        recent.text = inputText6.text;
    }

    public void NINE()
    {
        inputText6.text = recent.text + "9";
        recent.text = inputText6.text;
    }

    public void ZERO()
    {
        inputText6.text = recent.text + "0";
        recent.text = inputText6.text;
    }

    public void DELETE()
    {
        inputText6.text = null;
        user_num6 = 0;
    }

    public void CHECK()
    {
        user_num6 = Convert.ToInt32(inputText6.text);
    }
}
