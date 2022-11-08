using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList9 : MonoBehaviour
{
    public Text inputText9; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num9;

    public void ONE()
    {
        inputText9.text = recent.text + "1";
        recent.text = inputText9.text;
    }

    public void TWO()
    {
        inputText9.text = recent.text + "2";
        recent.text = inputText9.text;
    }

    public void THREE()
    {
        inputText9.text = recent.text + "3";
        recent.text = inputText9.text;
    }

    public void FOUR()
    {
        inputText9.text = recent.text + "4";
        recent.text = inputText9.text;
    }

    public void FIVE()
    {
        inputText9.text = recent.text + "5";
        recent.text = inputText9.text;
    }

    public void SIX()
    {
        inputText9.text = recent.text + "6";
        recent.text = inputText9.text;
    }

    public void SEVEN()
    {
        inputText9.text = recent.text + "7";
        recent.text = inputText9.text;
    }

    public void EIGHT()
    {
        inputText9.text = recent.text + "8";
        recent.text = inputText9.text;
    }

    public void NINE()
    {
        inputText9.text = recent.text + "9";
        recent.text = inputText9.text;
    }

    public void ZERO()
    {
        inputText9.text = recent.text + "0";
        recent.text = inputText9.text;
    }

    public void DELETE()
    {
        inputText9.text = null;
        user_num9 = 0;
    }

    public void CHECK()
    {
        user_num9 = Convert.ToInt32(inputText9.text);
    }
}
