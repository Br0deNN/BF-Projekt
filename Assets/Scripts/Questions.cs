using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    [SerializeField] List<GameObject> activeQuestions = new List<GameObject>();
    List<GameObject> usedQuestions = new List<GameObject>();

    public void ShowQuestions()
    {
        int r = Random.Range(0, activeQuestions.Count);
        activeQuestions[r].SetActive(true);

        usedQuestions.Add(activeQuestions[r]);
        activeQuestions.RemoveAt(r);
        if(activeQuestions.Count == 0 )
        {
            activeQuestions = usedQuestions;
            usedQuestions = new List<GameObject>(usedQuestions);
            
        }

    }



}
