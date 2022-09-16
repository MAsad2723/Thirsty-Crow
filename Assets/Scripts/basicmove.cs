using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicmove : MonoBehaviour
{
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalmovement = Input.GetAxis("Vertical") * Time.deltaTime;
        float horizontalmovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-.1f, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0.1f, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0 , -0.1f, 0));
        }
    }
}
