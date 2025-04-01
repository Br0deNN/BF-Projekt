using Unity.VisualScripting;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    public GameObject button;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            button.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}
