using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    //public List<Text> use = new List<Text>();
    public Text use;
    public Text recent = null; // 적혀있는 값
    public int recentnum;
    public int percent; // delete나누었을때
    public List<Text> num = new List<Text>();
    public int stopnum; // 멈추 점수
    public int btncount;

    void Start()
    {
        recentnum = 0;
        stopnum =0 ;
        btncount =0;
    }

    void Update()
    {
        
    }

    public void ONE()
    {
        use.text = recent.text + num[0].text;
        recent.text = use.text;
        stopnum = 1;
        btncount++;
    }

    public void TWO()
    {
        use.text = recent.text + num[1].text;
        recent.text = use.text;
        stopnum = 2;
        btncount++;
    }

    public void THREE()
    {
        use.text = recent.text + num[2].text;
        recent.text = use.text;
        stopnum = 3;
        btncount++;
    }
/*
    public void DELETE()
    {
        if(btncount = 1){
            recentnum = int.Parse(recent.text) % (btncount*1);
            btncount = 0;
        }

        if(btncount = 2){
            recentnum = int.Parse(recent.text) % (btncount*10);
        }

        //recentnum = int.Parse(recent.text) / (btncount*10);
        btncount = 0;
        //int.Parse(recent.text) - stopnum;
        use.text = recentnum.ToString();
    }
*/
}
