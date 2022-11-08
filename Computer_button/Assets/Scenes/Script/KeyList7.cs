using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList7 : MonoBehaviour
{
    public Text inputText7; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public static int user_num7;

    public void ONE()
    {
        inputText7.text = recent.text + "1";
        recent.text = inputText7.text;
    }

    public void TWO()
    {
        inputText7.text = recent.text + "2";
        recent.text = inputText7.text;
    }

    public void THREE()
    {
        inputText7.text = recent.text + "3";
        recent.text = inputText7.text;
    }

    public void FOUR()
    {
        inputText7.text = recent.text + "4";
        recent.text = inputText7.text;
    }

    public void FIVE()
    {
        inputText7.text = recent.text + "5";
        recent.text = inputText7.text;
    }

    public void SIX()
    {
        inputText7.text = recent.text + "6";
        recent.text = inputText7.text;
    }

    public void SEVEN()
    {
        inputText7.text = recent.text + "7";
        recent.text = inputText7.text;
    }

    public void EIGHT()
    {
        inputText7.text = recent.text + "8";
        recent.text = inputText7.text;
    }

    public void NINE()
    {
        inputText7.text = recent.text + "9";
        recent.text = inputText7.text;
    }

    public void ZERO()
    {
        inputText7.text = recent.text + "0";
        recent.text = inputText7.text;
    }

    public void DELETE()
    {
        inputText7.text = null;
        user_num7 = 0;
    }

    public void CHECK()
    {
        user_num7 = Convert.ToInt32(inputText7.text);
    }
}
