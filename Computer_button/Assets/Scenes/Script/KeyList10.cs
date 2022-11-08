using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList10 : MonoBehaviour
{
    public Text inputText10; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public static int user_num10;

    public void ONE()
    {
        inputText10.text = recent.text + "1";
        recent.text = inputText10.text;
    }

    public void TWO()
    {
        inputText10.text = recent.text + "2";
        recent.text = inputText10.text;
    }

    public void THREE()
    {
        inputText10.text = recent.text + "3";
        recent.text = inputText10.text;
    }

    public void FOUR()
    {
        inputText10.text = recent.text + "4";
        recent.text = inputText10.text;
    }

    public void FIVE()
    {
        inputText10.text = recent.text + "5";
        recent.text = inputText10.text;
    }

    public void SIX()
    {
        inputText10.text = recent.text + "6";
        recent.text = inputText10.text;
    }

    public void SEVEN()
    {
        inputText10.text = recent.text + "7";
        recent.text = inputText10.text;
    }

    public void EIGHT()
    {
        inputText10.text = recent.text + "8";
        recent.text = inputText10.text;
    }

    public void NINE()
    {
        inputText10.text = recent.text + "9";
        recent.text = inputText10.text;
    }

    public void ZERO()
    {
        inputText10.text = recent.text + "0";
        recent.text = inputText10.text;
    }

    public void DELETE()
    {
        inputText10.text = null;
        user_num10 = 0;
    }

    public void CHECK()
    {
        user_num10 = Convert.ToInt32(inputText10.text);
    }
}
