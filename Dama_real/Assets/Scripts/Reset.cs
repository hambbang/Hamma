using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Start");
        Sick.isSick = false;
        Hungry.hungry = 10;
        Cleanly.cleanly = 10;
        Happy.happy = 10;
        ShowName.age = 1;
    }
}
