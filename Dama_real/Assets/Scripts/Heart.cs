using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart;
    public float gauge;
    SpriteRenderer sr;
    private void Start()
    {
        sr=heart.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        switch (ShowName.value)
        {
            case 1:
                if (Hungry.hungry > gauge)
                {
                    heart.gameObject.SetActive(true);
                    sr.material.color = new Color(1,0.75f,0.75f);
                }
                else
                    heart.gameObject.SetActive(false);
                break;
            case 2:
                if (Happy.happy > gauge)
                {
                    heart.gameObject.SetActive(true);
                    sr.material.color = new Color(1, 1f, 0.75f);
                }
                else
                    heart.gameObject.SetActive(false);    
                break;
            case 3:
                if (Cleanly.cleanly > gauge)
                {
                    heart.gameObject.SetActive(true);
                    sr.material.color = new Color(0.75f, 1f, 0.75f);
                }
                else
                    heart.gameObject.SetActive(false);
                break;
            case 4:
                if (Hungry.hungry > gauge)//피로로 수정
                {
                    heart.gameObject.SetActive(true);
                    sr.material.color = new Color(0.75f, 1f, 1f);
                }
                else
                    heart.gameObject.SetActive(false);
                break;
        }
    }
}
