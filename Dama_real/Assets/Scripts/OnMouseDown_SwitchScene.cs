using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseDown_SwitchScene : MonoBehaviour
{
    public string SceneName;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
