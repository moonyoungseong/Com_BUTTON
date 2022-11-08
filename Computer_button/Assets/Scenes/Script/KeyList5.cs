using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList5 : MonoBehaviour
{
    public Text inputText5; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public static int user_num5;

    public void ONE()
    {
        inputText5.text = recent.text + "1";
        recent.text = inputText5.text;
    }

    public void TWO()
    {
        inputText5.text = recent.text + "2";
        recent.text = inputText5.text;
    }

    public void THREE()
    {
        inputText5.text = recent.text + "3";
        recent.text = inputText5.text;
    }

    public void FOUR()
    {
        inputText5.text = recent.text + "4";
        recent.text = inputText5.text;
    }

    public void FIVE()
    {
        inputText5.text = recent.text + "5";
        recent.text = inputText5.text;
    }

    public void SIX()
    {
        inputText5.text = recent.text + "6";
        recent.text = inputText5.text;
    }

    public void SEVEN()
    {
        inputText5.text = recent.text + "7";
        recent.text = inputText5.text;
    }

    public void EIGHT()
    {
        inputText5.text = recent.text + "8";
        recent.text = inputText5.text;
    }

    public void NINE()
    {
        inputText5.text = recent.text + "9";
        recent.text = inputText5.text;
    }

    public void ZERO()
    {
        inputText5.text = recent.text + "0";
        recent.text = inputText5.text;
    }

    public void DELETE()
    {
        inputText5.text = null;
        user_num5 = 0;
    }

    public void CHECK()
    {
        user_num5 = Convert.ToInt32(inputText5.text);
    }
}
