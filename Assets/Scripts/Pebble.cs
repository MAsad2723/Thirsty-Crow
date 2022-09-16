using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebble : MonoBehaviour
{
    Collectible collectible;
    
    private void OnTriggerEnter(Collider other)
    {
        collectible = other.GetComponent<Collectible>();
        if (collectible != null)
        {
            collectible.PebbleCollected();
            gameObject.SetActive(false);
        }
        

        }
    }
