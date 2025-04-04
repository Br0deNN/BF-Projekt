using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    [SerializeField] int starAmount;
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
