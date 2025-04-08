using UnityEngine;

public class Click2DObject : MonoBehaviour
{
    public GameObject button;
    public ManagerScript script;
    

    private void OnMouseDown()
    {
        if(script.questionActive == false)
        {
            Debug.Log("Clicked");
            button.SetActive(true);
            script.toggleQA();
            this.gameObject.SetActive(false);
        }
    }
}
