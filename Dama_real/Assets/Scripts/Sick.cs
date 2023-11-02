using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sick : MonoBehaviour
{
    public static float sickTime = 0f;  // 병 걸린 시간
    public float sickDead = 5f;  // 게임 오버 기준 시간
    public  static bool isSick=false;
    SpriteRenderer h;
    private void Start()
    {
         h = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Cleanly.cleanly <= 5f&&isSick==false)
        {
            // 랜덤으로 변수 값을 1로 설정
            if (Random.Range(0, 1000) < 0.5f)  // 50% 확률 업데이트에 넣어놔서 거의 무조건임
            {
                Animations.Sick = true;
                isSick = true;
                Debug.Log("나아파");
            }
        }
        if (isSick == true)
        {
            sickTime += Time.deltaTime;
            h.material.color = new Color(1, 1, 1, 1);
        }
        else
        {
            sickTime = 0;
            h.material.color = new Color(1, 1, 1, 0.6f);
        }
        if (sickTime >= sickDead)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("아파서 죽음");
        }
    }
    private void OnMouseDown()
    {
        if (isSick == true)
        {
            isSick = false;
            Debug.Log("안아포");
        }
    }

}