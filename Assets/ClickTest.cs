using UnityEngine;

public class Click2DObject : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject button;

=======
>>>>>>> Stashed changes
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect left-click
        {
<<<<<<< Updated upstream
            Debug.Log("Clicked");
            button.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

=======
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Clicked on: " + hit.collider.name);

                // Call a function on the clicked object (if it has a ButtonAction script)
                hit.collider.GetComponent<ButtonAction>()?.OnClick();
            }
            else
            {
                Debug.Log("No object hit.");
            }
        }
    }
>>>>>>> Stashed changes
}
