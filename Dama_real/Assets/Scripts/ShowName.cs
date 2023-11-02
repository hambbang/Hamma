using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    public static float age = 1;
    public static int value = 1;
    public Text aget;

    private void Start()
    {
        InvokeRepeating("IncreaseAge", 10f, 10f);
    }

    private void Update()
    {
        aget.text = "age:" + age.ToString("F0");

        switch (value)
        {
            case 1:
                GetComponent<Text>().text = "Hungry";
                break;
            case 2:
                GetComponent<Text>().text = "Happy";
                break;
            case 3:
                GetComponent<Text>().text = "Clean";
                break;
            case 4:
                GetComponent<Text>().text = "Fatigue";
                break;
        }
    }

    private void IncreaseAge()
    {
        age += 1f;
    }
}