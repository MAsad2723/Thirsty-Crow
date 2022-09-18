using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject obj;
    private int totalstone = 0;
    public void Start()
    {
        totalstone = GetComponent<Collectible>().NumberofPebbles;
        while (totalstone > 0)
        {
            StartCoroutine(playAnimation());
            Debug.Log("pebble dropped " + totalstone);
            GetComponent<Collectible>().PebbleDecollected();
            totalstone--;
        }
        this.enabled = false;
    }

    public IEnumerator playAnimation()
    { //method name can be delay()
    yield return new WaitForSeconds(3f);
        // Insert your Play Animations here
            Instantiate(obj);
    }
}
