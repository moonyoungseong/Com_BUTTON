using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFilterred : MonoBehaviour
{
    private Wilberforce.Colorblind c;

    public void ChangeFilterr()
    {
        GameObject cfr = GameObject.Find("ColorFilter");
        c = cfr.GetComponent<Wilberforce.Colorblind>();
        c.Type = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
