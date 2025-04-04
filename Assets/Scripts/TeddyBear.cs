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
         
        GetComponent<Image>().sprite = clothes[0];
    }

  

    
    public void ImageSwapper()
    {
        if(script.starAmount == 1)
        {
            GetComponent<Image>().sprite = clothes[1];
        }
        else if (script.starAmount == 2)
        {
            GetComponent<Image>().sprite = clothes[2];
        }
        else if (script.starAmount == 4)
        {
            GetComponent<Image>().sprite = clothes[3];
        }
        else if (script.starAmount == 5)
        {
            transform.position = new Vector3(2.2f , -0.41f , 10);
            transform.rotation = Quaternion.EulerAngles(new Vector3(52.7f , 0 , 70 ));
        }






        Debug.Log("clicked");

    }
}
