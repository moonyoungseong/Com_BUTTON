using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList8 : MonoBehaviour
{
    public Text inputText8; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public static int user_num8;

    public void ONE()
    {
        inputText8.text = recent.text + "1";
        recent.text = inputText8.text;
    }

    public void TWO()
    {
        inputText8.text = recent.text + "2";
        recent.text = inputText8.text;
    }

    public void THREE()
    {
        inputText8.text = recent.text + "3";
        recent.text = inputText8.text;
    }

    public void FOUR()
    {
        inputText8.text = recent.text + "4";
        recent.text = inputText8.text;
    }

    public void FIVE()
    {
        inputText8.text = recent.text + "5";
        recent.text = inputText8.text;
    }

    public void SIX()
    {
        inputText8.text = recent.text + "6";
        recent.text = inputText8.text;
    }

    public void SEVEN()
    {
        inputText8.text = recent.text + "7";
        recent.text = inputText8.text;
    }

    public void EIGHT()
    {
        inputText8.text = recent.text + "8";
        recent.text = inputText8.text;
    }

    public void NINE()
    {
        inputText8.text = recent.text + "9";
        recent.text = inputText8.text;
    }

    public void ZERO()
    {
        inputText8.text = recent.text + "0";
        recent.text = inputText8.text;
    }

    public void DELETE()
    {
        inputText8.text = null;
        user_num8 = 0;
    }

    public void CHECK()
    {
        user_num8 = Convert.ToInt32(inputText8.text);
    }
}
