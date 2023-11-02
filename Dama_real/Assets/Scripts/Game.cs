using Ludiq;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class Game : MonoBehaviour
{
    // 게임 내부적으로 사용되는 변수
    private int answer;
    public static int currentAnswer = 10;
    private float moveSpeed = 5f;
    private GameObject targetObject;
    private Vector3 initialPosition;
    public GameObject oobject;
    public Text t1;
    public int score = 0;   


    // 게임 시작 시 초기화
    void Start()
    {
        // 랜덤으로 정답을 지정
        initialPosition = transform.position;
        answer = Random.Range(1, 4);
    }
    // 매 프레임마다 호출
    void Update()
    {
        t1.text = "score:" + score.ToString("F0");
        int i = 0;
        while (i < 5)
        {
            // 정답이 선택되지 않은 상태일 경우 랜덤으로 정답 선택
            if (currentAnswer == 10)
            {
                answer = Random.Range(1, 4);
            }
            // 정답이 선택된 상태일 경우
            else if (currentAnswer != 10)
            {
                // 정답 선택 시
                if (answer == currentAnswer)
                {
                    MoveToTarget();

                    score += 1;
                    currentAnswer = 10;
                    Happy.happy += 2f;
                }
                // 오답 선택 시
                else
                {

                    Happy.happy += 1f;
                    currentAnswer = 10;
                }
            }

            // 점수가 5점 이상인 경우 타겟 오브젝트 활성화
            if (score > 4)
            {
                Happy.happy = 10;
            }
            i++;
        }
        oobject.gameObject.SetActive(true); 
    }
    // 목표 지점까지 이동하는 함수
    private void MoveToTarget()
    {
        float xDirection = 0f;
        float yDirection = 0f;
        switch (answer)
        {
            case 1:
                xDirection = -100f;
                break;
            case 2:
                yDirection = 0f;
                break;
            case 3:
                xDirection = 100f;
                break;
            default:
                break;
        }

        // 현재 위치에서 xDirection 만큼 이동
        transform.position += new Vector3(initialPosition.x +xDirection, 0f+yDirection, 0f) * Time.deltaTime;
    }
}
