using UnityEngine;
using UnityEngine.SceneManagement;

public class DropPebbles : MonoBehaviour
{
    public Vector3 offset;
    public GameObject obj;
    public Transform crow;
    public movement move;
    private int totalstone;
    public GameObject matka;
    public GameObject matka_filled;
    public void Update()
    {
        if(crow.position.x >= 9.5 && crow.position.x <= 10 && crow.position.z >= 57 && crow.position.z <= 58)
        {
            move.enabled = false;
            totalstone = GetComponent<Collectible>().NumberofPebbles;
            while(totalstone>0)
            {
                Instantiate(obj);
                Debug.Log("pebble dropped "+totalstone);
                GetComponent<Collectible>().PebbleDecollected();
                totalstone--;
            }
            matka.SetActive(false);
            matka_filled.SetActive(true);
            SceneManager.LoadScene(7);
            this.enabled = false;
        }
    }
}

