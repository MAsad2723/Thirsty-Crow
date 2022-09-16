using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Enemy : MonoBehaviour
{
    Collectible collectible;
    public int NumberofPebbles { get; private set; }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy") 
        {
             void PebbleDecollected()
            {
                NumberofPebbles--;
                
            }
        }
    }

}
