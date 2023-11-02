using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGo : MonoBehaviour
{
    public GameObject @object;
    
    void Start()
    {
        @object.SetActive(false);
    }
    private void Update()
    {
        
            
    }
    private void OnMouseDown()
    {

        @object.gameObject.SetActive(true);
        gameObject.SetActive(false);
        
    }
}
