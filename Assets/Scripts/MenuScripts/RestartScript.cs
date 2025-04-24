using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public string MainMenu;
    public void RestartGame()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
