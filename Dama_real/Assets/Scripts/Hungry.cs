using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hungry : MonoBehaviour
{
    public static float hungry = 10;
    public float addhungry = 1;
    public static float hungerTime = 0f;  // 포만도가 0인 시간
    public GameObject real;
    public GameObject jjap;


    public void OnMouseDown()   
    {
        if (hungry + addhungry > 10) {
            real.SetActive(false);
            jjap.SetActive(true);
            Invoke("DelayedFunction", 1.0f);
            
        }
        else hungry += addhungry;
    }
    public void Update()
    {
        if(hungry > 0)
            hungry -= 0.0005f;
        if (hungry <= 0)
        {
            hungerTime += Time.deltaTime;
        }
        else
        {
            hungerTime = 0f;
        }
        if (hungerTime >=10)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("배고파서 죽음");
        }
    }
    private void DelayedFunction()
    {
        Debug.Log("딜레이 해 드렸습니다~");
        real.SetActive(true);
        jjap.SetActive(false);
    }
}
