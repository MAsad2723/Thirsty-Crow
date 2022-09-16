using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Collectible : MonoBehaviour
{
    public int NumberofPebbles{get;private set;}
    int count;
    public UnityEvent<Collectible> OnPebbleCollected;
    public UnityEvent<Collectible> OnPebbleDecollected;
    public GameObject obj;
    public void PebbleCollected()
    {
        NumberofPebbles++;
        OnPebbleCollected.Invoke(this);
        count = NumberofPebbles;
    }
    public void PebbleDecollected() 
    {
        NumberofPebbles--;
        OnPebbleDecollected.Invoke(this);
        Instantiate(obj, transform.position, transform.rotation);
    }


}
