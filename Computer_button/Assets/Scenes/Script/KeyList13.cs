using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList13 : MonoBehaviour
{
    public Text inputText13; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public int user_num13;

    public void ONE()
    {
        inputText13.text = recent.text + "1";
        recent.text = inputText13.text;
    }

    public void TWO()
    {
        inputText13.text = recent.text + "2";
        recent.text = inputText13.text;
    }

    public void THREE()
    {
        inputText13.text = recent.text + "3";
        recent.text = inputText13.text;
    }

    public void FOUR()
    {
        inputText13.text = recent.text + "4";
        recent.text = inputText13.text;
    }

    public void FIVE()
    {
        inputText13.text = recent.text + "5";
        recent.text = inputText13.text;
    }

    public void SIX()
    {
        inputText13.text = recent.text + "6";
        recent.text = inputText13.text;
    }

    public void SEVEN()
    {
        inputText13.text = recent.text + "7";
        recent.text = inputText13.text;
    }

    public void EIGHT()
    {
        inputText13.text = recent.text + "8";
        recent.text = inputText13.text;
    }

    public void NINE()
    {
        inputText13.text = recent.text + "9";
        recent.text = inputText13.text;
    }

    public void ZERO()
    {
        inputText13.text = recent.text + "0";
        recent.text = inputText13.text;
    }

    public void DELETE()
    {
        inputText13.text = null;
        user_num13 = 0;
    }

    public void CHECK()
    {
        user_num13 = Convert.ToInt32(inputText13.text);
    }
}
