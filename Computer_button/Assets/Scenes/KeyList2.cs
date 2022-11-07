using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList2 : MonoBehaviour
{
    public List<Text> btnnum2 = new List<Text>(); // 버튼의 텍스트 값;
    public Text inputText2; // 입력란
    public Text recent2 = null; // 적혀있는 값
    public int user_num2;

    public void ONE()
    {
        inputText2.text = recent2.text + btnnum2[0].text;
        recent2.text = inputText2.text;
    }

    public void TWO()
    {
        inputText2.text = recent2.text + btnnum2[1].text;
        recent2.text = inputText2.text;
    }

    public void THREE()
    {
        inputText2.text = recent2.text + btnnum2[2].text;
        recent2.text = inputText2.text;
    }

    public void FOUR()
    {
        inputText2.text = recent2.text + btnnum2[3].text;
        recent2.text = inputText2.text;
    }

    public void FIVE()
    {
        inputText2.text = recent2.text + btnnum2[4].text;
        recent2.text = inputText2.text;
    }

    public void SIX()
    {
        inputText2.text = recent2.text + btnnum2[5].text;
        recent2.text = inputText2.text;
    }

    public void SEVEN()
    {
        inputText2.text = recent2.text + btnnum2[6].text;
        recent2.text = inputText2.text;
    }

    public void EIGHT()
    {
        inputText2.text = recent2.text + btnnum2[7].text;
        recent2.text = inputText2.text;
    }

    public void NINE()
    {
        inputText2.text = recent2.text + btnnum2[8].text;
        recent2.text = inputText2.text;
    }

    public void ZERO()
    {
        inputText2.text = recent2.text + btnnum2[9].text;
        recent2.text = inputText2.text;
    }

    public void DELETE()
    {
        inputText2.text = null;
        user_num2 = 0;
    }

    public void CHECK()
    {
        //user_num2 = int.Parse(inputText2.text);
        user_num2 = Convert.ToInt32(inputText2.text);
    }
}
