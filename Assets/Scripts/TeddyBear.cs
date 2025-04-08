using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TeddyBear : MonoBehaviour
{
    [Header("ClothesSwap")]
    [SerializeField] List<Sprite> clothes = new List<Sprite>();
    public ManagerScript script;


    private void Start()
    {
         
        GetComponent<SpriteRenderer>().sprite = clothes[0];
    }

  

    
    public void ImageSwapper()
    {
        if(script.starAmount == 1)
        {
            GetComponent<SpriteRenderer>().sprite = clothes[1];
            Debug.Log("Fit1");
        }
        else if (script.starAmount == 2)
        {
            GetComponent<SpriteRenderer>().sprite = clothes[2];
            Debug.Log("Fit2");
        }
        else if (script.starAmount == 4)
        {
            GetComponent<SpriteRenderer>().sprite = clothes[3];
            Debug.Log("Fit3");
        }
        else if (script.starAmount == 5)
        {
            transform.position = new Vector3(2.2f , -0.41f , -3);
            transform.rotation = Quaternion.Euler(new Vector3(52.7f , 0 , 70 ));
            Debug.Log("Move");
        }
    }
}
