using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeddyBear : MonoBehaviour
{
    [Header("ClothesSwap")]
    [SerializeField] List<Sprite> clothes = new List<Sprite>();
    public ManagerScript script;


    int index = 0;

    private void Start()
    {
         
        GetComponent<Image>().sprite = clothes[index];
    }

  

    
    public void ImageSwapper()
    {
        
        
        GetComponent<Image>().sprite = clothes[++index];




        Debug.Log("clicked");

    }
}
