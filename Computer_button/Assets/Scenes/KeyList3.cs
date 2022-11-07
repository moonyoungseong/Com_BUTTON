using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList3 : MonoBehaviour
{
    public List<Text> btnnum3 = new List<Text>(); // 버튼의 텍스트 값;
    public Text inputText3; // 입력란
    public Text recen3t = null; // 적혀있는 값
    public int user_num3;

    public void ONE()
    {
        inputText3.text = recen3t.text + btnnum3[0].text;
        recen3t.text = inputText3.text;
    }

    public void TWO()
    {
        inputText3.text = recen3t.text + btnnum3[1].text;
        recen3t.text = inputText3.text;
    }

    public void THREE()
    {
        inputText3.text = recen3t.text + btnnum3[2].text;
        recen3t.text = inputText3.text;
    }

    public void FOUR()
    {
        inputText3.text = recen3t.text + btnnum3[3].text;
        recen3t.text = inputText3.text;
    }

    public void FIVE()
    {
        inputText3.text = recen3t.text + btnnum3[4].text;
        recen3t.text = inputText3.text;
    }

    public void SIX()
    {
        inputText3.text = recen3t.text + btnnum3[5].text;
        recen3t.text = inputText3.text;
    }

    public void SEVEN()
    {
        inputText3.text = recen3t.text + btnnum3[6].text;
        recen3t.text = inputText3.text;
    }

    public void EIGHT()
    {
        inputText3.text = recen3t.text + btnnum3[7].text;
        recen3t.text = inputText3.text;
    }

    public void NINE()
    {
        inputText3.text = recen3t.text + btnnum3[8].text;
        recen3t.text = inputText3.text;
    }

    public void ZERO()
    {
        inputText3.text = recen3t.text + btnnum3[9].text;
        recen3t.text = inputText3.text;
    }

    public void DELETE()
    {
        inputText3.text = null;
        user_num3 = 0;
    }

    public void CHECK()
    {
        //user_num3 = int.Parse(inputText3.text);
        user_num3 = Convert.ToInt32(inputText3.text);
    }
}
