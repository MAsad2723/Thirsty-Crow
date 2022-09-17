using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    void Start()
    {
        speedModifier = 0.01f;
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x *10f*(Time.deltaTime*Time.deltaTime), transform.position.y + touch.deltaPosition.y * 10f*(Time.deltaTime * Time.deltaTime), transform.position.z );
            }
        }
    }
}
