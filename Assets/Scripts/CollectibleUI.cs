using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollectibleUI : MonoBehaviour
{
    private TextMeshProUGUI pebbleText;
    // Start is called before the first frame update
    void Start()
    {
        pebbleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdatePebbleText(Collectible collectible)
    {
        pebbleText.text = collectible.NumberofPebbles.ToString();
    }
   
}
