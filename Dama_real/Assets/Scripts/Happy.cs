using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Happy : MonoBehaviour
{
    public static float happy=10;
    public static float happyTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (happy > 0)
            happy -= 0.0005f;
        if (happy <= 0)
        {
            happyTime += Time.deltaTime;
        }
        if (happy +0.5f > 10)
            Animations.Imfull = true;
        else if(happy>1 )
        {
            happyTime = 0f;
        }
        if (happyTime >= 10)
        {
            Debug.Log("우울해서 죽음");
            SceneManager.LoadScene("GameOver");

        }
    }
}
