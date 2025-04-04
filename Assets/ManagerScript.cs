using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    public int starAmount;
    public bool questionActive;

    public void addStar()
    {
        starAmount++;
    }

    public void toggleQA()
    {
        questionActive = !questionActive;
    }
}
