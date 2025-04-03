using UnityEngine;

public class BasegameScript : MonoBehaviour
{
    [SerializeField] int starAmount;

    public void starIncrease()
    {
        starAmount++;
    }
}
