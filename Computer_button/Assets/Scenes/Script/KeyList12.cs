using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList12 : MonoBehaviour
{
    public Text inputText12; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public static int user_num12;

    public void ONE()
    {
        inputText12.text = recent.text + "1";
        recent.text = inputText12.text;
    }

    public void TWO()
    {
        inputText12.text = recent.text + "2";
        recent.text = inputText12.text;
    }

    public void THREE()
    {
        inputText12.text = recent.text + "3";
        recent.text = inputText12.text;
    }

    public void FOUR()
    {
        inputText12.text = recent.text + "4";
        recent.text = inputText12.text;
    }

    public void FIVE()
    {
        inputText12.text = recent.text + "5";
        recent.text = inputText12.text;
    }

    public void SIX()
    {
        inputText12.text = recent.text + "6";
        recent.text = inputText12.text;
    }

    public void SEVEN()
    {
        inputText12.text = recent.text + "7";
        recent.text = inputText12.text;
    }

    public void EIGHT()
    {
        inputText12.text = recent.text + "8";
        recent.text = inputText12.text;
    }

    public void NINE()
    {
        inputText12.text = recent.text + "9";
        recent.text = inputText12.text;
    }

    public void ZERO()
    {
        inputText12.text = recent.text + "0";
        recent.text = inputText12.text;
    }

    public void DELETE()
    {
        inputText12.text = null;
        user_num12 = 0;
    }

    public void CHECK()
    {
        user_num12 = Convert.ToInt32(inputText12.text);
    }
}
