using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LorR : MonoBehaviour
{
    public int addValue = 1;
    private void OnMouseDown()
    {
        ShowName.value += addValue;
        if (ShowName.value > 4)
            ShowName.value = 1;
        if (ShowName.value < 1)
            ShowName.value = 4;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
