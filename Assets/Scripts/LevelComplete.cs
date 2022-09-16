using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
    public static int count = 2;
    public void NextLevel()
    {
        SceneManager.LoadScene(count);
        count++;
    }
}
