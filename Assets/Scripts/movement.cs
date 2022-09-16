using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    private int count=0;
    public float speed = 0.05f;
    public float x, y;
    private Touch touch;
    public GameObject obj;
    public Collectible collectible;
    SwipeManager sm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sm=GetComponent<SwipeManager>();
        collectible = GetComponent<Collectible>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 8f * Time.deltaTime));
        
                // rb.AddForce(0, 0, 100 * Time.deltaTime);
        // float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime;
        //float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        //x = Input.GetAxis("Horizontal");
        //y = Input.GetAxis("Vertical");
        //transform.Translate(x * speed, 0f, y * speed);
        /*if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -10f, 0));
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            //Vector3 touchPosition=Camera.main.ScreenToWorldPoint(touch.position);
            //touchPosition.z = 0f;
            //transform.position = touchPosition;
            float middle = Screen.height / 2;
            float mid = Screen.width / 2;
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
            }
            //else if (touch.phase == TouchPhase.Began)
            //{
             //   transform.position = new Vector3(transform.position.x , transform.position.y + touch.deltaPosition.x * 1f, transform.position.z);
            //}
        //}
            else if (touch.phase == TouchPhase.Began) { 
            if (touch.position.y > middle)
            {
                transform.Translate(new Vector3(0, 10f, 0));
            }
            else if (touch.position.y < middle)
            {
                transform.Translate(new Vector3(0, -10f, 0));
            }
            }
            //else if (touch.phase == TouchPhase.Moved)
            //{
              //  if (touch.position.x > mid) { 
               // transform.Translate(new Vector3(10f, 0, 0));
                //}
                //else if (touch.position.x < mid)
                //{
                  //  transform.Translate(new Vector3(-10f, 0, 0));
                //}
                //transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
            }
       /* else{
               if (SwipeManager.swipeRight)
       {
          transform.Translate(new Vector3(10f, 0, 0));
      }
        if (SwipeManager.swipeLeft)
        {
          transform.Translate(new Vector3(-10f, 0, 0));
        }
        }
          /*  else if (touch.position.x > mid&&touch.phase==TouchPhase.Moved)
            {
                transform.Translate(new Vector3(10f, 0, 0));
            }
            else if (touch.position.x < mid && touch.phase == TouchPhase.Moved)
            {
                transform.Translate(new Vector3(-10f, 0, 0));
            }
        if (SwipeManager.swipeRight)
        {
            transform.Translate(new Vector3(10f, 0, 0));
        }
        else if (SwipeManager.swipeLeft)
        {
            transform.Translate(new Vector3(-10f, 0, 0));
        }*/
       
    }
       
       // float verticalMovement = Input.GetAxis("Vertical") * Time.deltaTime;
        //float horizontalMovement = Input.GetAxis("Horizontal") * Time.deltaTime;
        //transform.Translate(new Vector3(FixedJoystick.Horizontal * 0.1f, 0, FixedJoystick.Vertical * 0.1f));
       // if (Input.touchCount > 0)
        //{
         //   touch = Input.GetTouch(0);
          //  if (touch.phase == TouchPhase.Moved)
           // {
            //    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
            //}
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            collectible.PebbleDecollected();
            
        }
    }
    public void hello()
    { }
}
        

