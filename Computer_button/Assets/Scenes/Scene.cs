using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public List<GameObject> Question = new List<GameObject>();
    

    public void Click()
    {
        SceneManager.LoadScene("testing01");
    }
}
