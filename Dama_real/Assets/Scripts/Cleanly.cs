using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanly : MonoBehaviour
{
    public static float cleanly=10;
    public static float addClean = 0.001f;
    void Update()
    {
        if (Poopnew.isOn == 1)
            cleanly -= addClean * 5;
        else
            cleanly -= addClean;
    }
}
