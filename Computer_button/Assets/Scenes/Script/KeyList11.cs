using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList11 : MonoBehaviour
{
    public Text inputText11; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num11;

    public void ONE()
    {
        inputText11.text = recent.text + "1";
        recent.text = inputText11.text;
    }

    public void TWO()
    {
        inputText11.text = recent.text + "2";
        recent.text = inputText11.text;
    }

    public void THREE()
    {
        inputText11.text = recent.text + "3";
        recent.text = inputText11.text;
    }

    public void FOUR()
    {
        inputText11.text = recent.text + "4";
        recent.text = inputText11.text;
    }

    public void FIVE()
    {
        inputText11.text = recent.text + "1";
        recent.text = inputText11.text;
    }

    public void SIX()
    {
        inputText11.text = recent.text + "6";
        recent.text = inputText11.text;
    }

    public void SEVEN()
    {
        inputText11.text = recent.text + "7";
        recent.text = inputText11.text;
    }

    public void EIGHT()
    {
        inputText11.text = recent.text + "8";
        recent.text = inputText11.text;
    }

    public void NINE()
    {
        inputText11.text = recent.text + "9";
        recent.text = inputText11.text;
    }

    public void ZERO()
    {
        inputText11.text = recent.text + "0";
        recent.text = inputText11.text;
    }

    public void DELETE()
    {
        inputText11.text = null;
        user_num11 = 0;
    }

    public void CHECK()
    {
        user_num11 = Convert.ToInt32(inputText11.text);
    }
}
