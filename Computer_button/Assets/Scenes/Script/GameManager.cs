using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<int> use = new List<int>(); // 사용자 입렵값
    List<int> Accept = new List<int>() { 12, 26, 7, 57, 73, 2, 29, 8, 5, 3, 16, 7, 6, 96, 97, 15}; // 실제 답
    public Text jungdab; // 몇개 맞은지 텍스트

    public int totalScore = 0; 

    void Update()
    {
        use[0] = KeyList.user_num;
        use[1] = KeyList2.user_num2;
        use[2] = KeyList3.user_num3;
        use[3] = KeyList4.user_num4;
        use[4] = KeyList5.user_num5;
        use[5] = KeyList6.user_num6;
        use[6] = KeyList7.user_num7;
        use[7] = KeyList8.user_num8;
        use[8] = KeyList9.user_num9;
        use[9] = KeyList10.user_num10;
        use[10] = KeyList11.user_num11;
        use[11] = KeyList12.user_num12;
        use[12] = KeyList13.user_num13;
        use[13] = KeyList14.user_num14;
        use[14] = KeyList15.user_num15;
        use[15] = KeyList16.user_num16;
    }

    public void totalSum()
    {
        for (int i = 0; i < use.Count; i++)
        {
            if (use[i] == Accept[i])
            {
                totalScore += 1;
            }
        }

        jungdab.text = "맞은 개수는 16개 중 " + totalScore + "개입니다.";
    }
}
