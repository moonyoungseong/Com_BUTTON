using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriginalFilter : MonoBehaviour
{
    private Wilberforce.Colorblind c;

    public void Original()
    {
        GameObject cfr = GameObject.Find("ColorFilter");
        c = cfr.GetComponent<Wilberforce.Colorblind>();
        c.Type = 0;
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
