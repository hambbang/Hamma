using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IfTouchDrag : MonoBehaviour
{
    SpriteRenderer ham;
    Vector2 Mouse;
    Camera camera;
    public string what;
    public GameObject hamster;
    void Start()
    {
        camera=GameObject.Find("camera").GetComponent<Camera>();
        ham = hamster.GetComponent<SpriteRenderer>();
    }
    /*void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Mouse = Input.mousePosition;
            Mouse = camera.ScreenToWorldPoint(Mouse);
            transform.position = Mouse;
        }

    }*/
    private void OnMouseDrag()
    {
        Mouse = Input.mousePosition;
        Mouse = camera.ScreenToWorldPoint(Mouse);
        transform.position = Mouse;
        if(Cleanly.cleanly<10)
            Cleanly.cleanly +=0.005f;
        ham.material.color = new Color(0.8f,0.9f,1);
    }
    private void OnMouseUp()
    {
        ham.material.color = new Color(1, 1, 1);
    }
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name==what)
        {
            Cleanly.cleanly += 1.5f;
            Debug.Log("항복");
        }
    }*/
}
