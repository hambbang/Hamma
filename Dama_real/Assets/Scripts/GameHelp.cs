using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHelp : MonoBehaviour
{
    public int way;
    private void OnMouseDown()
    {
        Game.currentAnswer = way;
    }
}
