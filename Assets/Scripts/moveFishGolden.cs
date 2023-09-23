using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFishGolden : MonoBehaviour
{
    public float speed = 20f;
    private float rightBorder = 18.0f;
    private float leftBorder = -18.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.x >= rightBorder)
        {
            
            transform.rotation = Quaternion.Euler(0, 0, 0);
          
        }
        else if (transform.position.x <= leftBorder)
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

          if (Input.GetMouseButtonDown(0))
        {
            // Convert mouse click position to world position
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("fish: Mouse clicked at" + clickPosition);

            // Perform a raycast from the mouse click position
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            // Check if the raycast hits this fish
            if (hit.collider != null)
            {
                Debug.Log("fish: Raycast Hit: " + hit.collider.gameObject.name);
                // If the fish is clicked, make it invisible
                hit.collider.gameObject.SetActive(false);
            }
        }
    }
}
