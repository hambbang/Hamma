using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class realManyS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Hungry.hungry = 10;
            Cleanly.cleanly = 10;
            Happy.happy = 10;
            //피로도.피로도=0;    
            SceneManager.LoadScene("Main");

        }
    }
}
