using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public Questions questionManager; // Reference to the UI Question Manager

    public void OnClick()
    {
        Debug.Log("Button Clicked! Opening Question UI.");

        if (questionManager != null)
        {
            questionManager.ShowQuestions(); // Call your existing function
        }
        else
        {
            Debug.LogError("QuestionManager is not assigned!");
        }
    }
}
