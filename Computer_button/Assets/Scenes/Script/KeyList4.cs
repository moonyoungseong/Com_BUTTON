using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList4 : MonoBehaviour
{
    public Text inputText4; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num4;

    public void ONE()
    {
        inputText4.text = recent.text + "1";
        recent.text = inputText4.text;
    }

    public void TWO()
    {
        inputText4.text = recent.text + "2";
        recent.text = inputText4.text;
    }

    public void THREE()
    {
        inputText4.text = recent.text + "3";
        recent.text = inputText4.text;
    }

    public void FOUR()
    {
        inputText4.text = recent.text + "4";
        recent.text = inputText4.text;
    }

    public void FIVE()
    {
        inputText4.text = recent.text + "5";
        recent.text = inputText4.text;
    }

    public void SIX()
    {
        inputText4.text = recent.text + "6";
        recent.text = inputText4.text;
    }

    public void SEVEN()
    {
        inputText4.text = recent.text + "7";
        recent.text = inputText4.text;
    }

    public void EIGHT()
    {
        inputText4.text = recent.text + "8";
        recent.text = inputText4.text;
    }

    public void NINE()
    {
        inputText4.text = recent.text + "9";
        recent.text = inputText4.text;
    }

    public void ZERO()
    {
        inputText4.text = recent.text + "0";
        recent.text = inputText4.text;
    }

    public void DELETE()
    {
        inputText4.text = null;
        user_num4 = 0;
    }

    public void CHECK()
    {
        user_num4 = Convert.ToInt32(inputText4.text);
    }
}
