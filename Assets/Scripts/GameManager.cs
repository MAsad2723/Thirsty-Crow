using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }
   private void Update()
    {
        if (Input.touchCount > 0)
        {
            Time.timeScale = 1;
        }
    }
}
