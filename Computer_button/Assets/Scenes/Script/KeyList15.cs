using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList15 : MonoBehaviour
{
    public Text inputText15; // �Է¶�
    public Text recent = null; // �����ִ� ��
    public int user_num15;

    public void ONE()
    {
        inputText15.text = recent.text + "1";
        recent.text = inputText15.text;
    }

    public void TWO()
    {
        inputText15.text = recent.text + "2";
        recent.text = inputText15.text;
    }

    public void THREE()
    {
        inputText15.text = recent.text + "3";
        recent.text = inputText15.text;
    }

    public void FOUR()
    {
        inputText15.text = recent.text + "4";
        recent.text = inputText15.text;
    }

    public void FIVE()
    {
        inputText15.text = recent.text + "5";
        recent.text = inputText15.text;
    }

    public void SIX()
    {
        inputText15.text = recent.text + "6";
        recent.text = inputText15.text;
    }

    public void SEVEN()
    {
        inputText15.text = recent.text + "7";
        recent.text = inputText15.text;
    }

    public void EIGHT()
    {
        inputText15.text = recent.text + "8";
        recent.text = inputText15.text;
    }

    public void NINE()
    {
        inputText15.text = recent.text + "9";
        recent.text = inputText15.text;
    }

    public void ZERO()
    {
        inputText15.text = recent.text + "0";
        recent.text = inputText15.text;
    }

    public void DELETE()
    {
        inputText15.text = null;
        user_num15 = 0;
    }

    public void CHECK()
    {
        user_num15 = Convert.ToInt32(inputText15.text);
    }
}
