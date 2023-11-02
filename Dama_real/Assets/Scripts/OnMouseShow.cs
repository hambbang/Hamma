using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseShow : MonoBehaviour
{
    public GameObject appear;
    private void OnMouseEnter()
    {
        appear.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        appear.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
