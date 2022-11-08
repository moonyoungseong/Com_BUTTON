using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList : MonoBehaviour
{
    public Text inputText; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num;

    public void ONE()
    {
        inputText.text = recent.text + "1";
        recent.text = inputText.text;
    }

    public void TWO()
    {
        inputText.text = recent.text + "2";
        recent.text = inputText.text;
    }

    public void THREE()
    {
        inputText.text = recent.text + "3";
        recent.text = inputText.text;
    }

    public void FOUR()
    {
        inputText.text = recent.text + "4";
        recent.text = inputText.text;
    }

    public void FIVE()
    {
        inputText.text = recent.text + "5";
        recent.text = inputText.text;
    }

    public void SIX()
    {
        inputText.text = recent.text + "6";
        recent.text = inputText.text;
    }

    public void SEVEN()
    {
        inputText.text = recent.text + "7";
        recent.text = inputText.text;
    }

    public void EIGHT()
    {
        inputText.text = recent.text + "8";
        recent.text = inputText.text;
    }

    public void NINE()
    {
        inputText.text = recent.text + "9";
        recent.text = inputText.text;
    }

    public void ZERO()
    {
        inputText.text = recent.text + "0";
        recent.text = inputText.text;
    }

    public void DELETE()
    {
        inputText.text = null;
        user_num = 0;
    }

    public void CHECK()
    {
        user_num = Convert.ToInt32(inputText.text);
    }
}
