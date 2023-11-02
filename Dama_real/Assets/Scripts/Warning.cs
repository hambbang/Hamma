using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public GameObject warnImege;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Hungry.hungry < 3 || Cleanly.cleanly < 3 || Sick.isSick == true)//해피 0도 추가
        {
            warnImege.gameObject.SetActive(true);
        }
        else warnImege.gameObject.SetActive(false);
    }
}
