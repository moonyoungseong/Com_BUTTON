using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList16 : MonoBehaviour
{
    public Text inputText16; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num16;

    public void ONE()
    {
        inputText16.text = recent.text + "1";
        recent.text = inputText16.text;
    }

    public void TWO()
    {
        inputText16.text = recent.text + "2";
        recent.text = inputText16.text;
    }

    public void THREE()
    {
        inputText16.text = recent.text + "3";
        recent.text = inputText16.text;
    }

    public void FOUR()
    {
        inputText16.text = recent.text + "4";
        recent.text = inputText16.text;
    }

    public void FIVE()
    {
        inputText16.text = recent.text + "1";
        recent.text = inputText16.text;
    }

    public void SIX()
    {
        inputText16.text = recent.text + "6";
        recent.text = inputText16.text;
    }

    public void SEVEN()
    {
        inputText16.text = recent.text + "7";
        recent.text = inputText16.text;
    }

    public void EIGHT()
    {
        inputText16.text = recent.text + "8";
        recent.text = inputText16.text;
    }

    public void NINE()
    {
        inputText16.text = recent.text + "9";
        recent.text = inputText16.text;
    }

    public void ZERO()
    {
        inputText16.text = recent.text + "0";
        recent.text = inputText16.text;
    }

    public void DELETE()
    {
        inputText16.text = null;
        user_num16 = 0;
    }

    public void CHECK()
    {
        user_num16 = Convert.ToInt32(inputText16.text);
    }
}
