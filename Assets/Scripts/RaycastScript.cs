using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    RaycastHit hit;
    public GameObject obj;
    private void FixedUpdate()
    {   
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit))
           {
            if(hit.collider.tag == "jar")
            {
                Debug.Log("There is a Jar");
                Instantiate(obj, transform.position, transform.rotation);
            }
        }
    }
}
