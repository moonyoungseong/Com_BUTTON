using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class KeyList : MonoBehaviour
{
    public List<Text> btnnum = new List<Text>(); // 버튼의 텍스트 값;
    public Text inputText; // 입력란
    public Text recent = null; // 적혀있는 값
    public int user_num;

    public void ONE()
    {
        inputText.text = recent.text + btnnum[0].text;
        recent.text = inputText.text;
    }

    public void TWO()
    {
        inputText.text = recent.text + btnnum[1].text;
        recent.text = inputText.text;
    }

    public void THREE()
    {
        inputText.text = recent.text + btnnum[2].text;
        recent.text = inputText.text;
    }

    public void FOUR()
    {
        inputText.text = recent.text + btnnum[3].text;
        recent.text = inputText.text;
    }

    public void FIVE()
    {
        inputText.text = recent.text + btnnum[4].text;
        recent.text = inputText.text;
    }

    public void SIX()
    {
        inputText.text = recent.text + btnnum[5].text;
        recent.text = inputText.text;
    }

    public void SEVEN()
    {
        inputText.text = recent.text + btnnum[6].text;
        recent.text = inputText.text;
    }

    public void EIGHT()
    {
        inputText.text = recent.text + btnnum[7].text;
        recent.text = inputText.text;
    }

    public void NINE()
    {
        inputText.text = recent.text + btnnum[8].text;
        recent.text = inputText.text;
    }

    public void ZERO()
    {
        inputText.text = recent.text + btnnum[9].text;
        recent.text = inputText.text;
    }

    public void DELETE()
    {
        inputText.text = null;
        user_num = 0;
    }

    public void CHECK()
    {
        //user_num = int.Parse(inputText.text);
        user_num = Convert.ToInt32(inputText.text);
    }
}
