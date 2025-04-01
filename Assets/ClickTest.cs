using Unity.VisualScripting;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    public GameObject button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            button.SetActive(true);
        }
    }

}
