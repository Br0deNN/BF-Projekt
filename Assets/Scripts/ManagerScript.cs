using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public int starAmount;
    public bool questionActive;
    public GameObject victoryScreen;
    public void addStar()
    {

        starAmount++;
        if (starAmount == 5)
        {

            victoryScreen.SetActive(true);
        }
    }

    public void toggleQA()
    {
        questionActive = !questionActive;
    }
}
