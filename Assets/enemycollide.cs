using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycollide : MonoBehaviour
{
    Collectible collectible;
    private void OnTriggerEnter(Collider other)
    {
        collectible = other.GetComponent<Collectible>();
        if (collectible != null)
        {

            collectible.PebbleDecollected();
            
        }


    }
}
