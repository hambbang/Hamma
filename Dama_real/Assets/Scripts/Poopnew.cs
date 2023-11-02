using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Poopnew : MonoBehaviour
{
    public float minTime = 5.0f; // 활성화까지 최소 시간
    public float maxTime = 15.0f; // 활성화까지 최대 시간
    public GameObject dong;
    public static int isOn;
    private float timer = 0.0f;

    private void Start()
    {
        timer = Random.Range(minTime, maxTime); // 다음 활성화까지의 시간을 설정
    }

    private void Update()
    {
        if (!dong.activeSelf) // 게임 오브젝트가 비활성화된 경우
        {
            isOn = 0;
            timer -= Time.deltaTime; // 시간 감소
            if (timer <= 0.0f) // 활성화할 시간이 되면
            {
                dong.SetActive(true); 
                // 상태를 활성화된 상태로 변경
            }
        }
        else if(dong.activeSelf )// 게임 오브젝트가 활성화된 경우
        {
            isOn = 1;
            if (Poopmom.ck==1) // 클릭했을 때
            {
                dong.SetActive(false); ;
                timer = Random.Range(minTime, maxTime); // 다음 활성화까지의 시간을 설정
                Poopmom.ck = 0;    
            }
        }
    }
}