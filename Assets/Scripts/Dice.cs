using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{

    [Header("DiceSides")]
    [SerializeField] List<Sprite> sides = new List<Sprite>();

    public void ImageSwapper()
    {
        int r = Random.Range(0, sides.Count);
        GetComponent<Image>().sprite = sides[r];
        
           
        Debug.Log("clicked");
        
    }

}


