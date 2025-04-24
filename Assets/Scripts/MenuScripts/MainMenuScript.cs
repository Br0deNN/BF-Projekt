using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string Startscene;

    public void StartGame()
    {
        SceneManager.LoadScene(Startscene);
    }
}
