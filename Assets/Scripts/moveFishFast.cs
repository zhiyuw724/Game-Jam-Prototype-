using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFishFast : MonoBehaviour
{
    public float speed = 7f;
    private float rightBorder = 18.0f;
    private float leftBorder = -18.0f;
    private heatLevel heatLevelScript;
    // Start is called before the first frame update
    void Start()
    {
        heatLevelScript = FindObjectOfType<heatLevel>();
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

          if (Input.GetMouseButtonDown(0) && heatLevelScript != null && heatLevelScript.currentHeatLevel >= 60)
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(clickPosition.y < 0.40 && clickPosition.y >= - 5.10 ){
            Debug.Log("fish fast: Mouse clicked at" + clickPosition);
            // Perform a raycast from the mouse click position
            RaycastHit2D hit = Physics2D.Raycast(clickPosition, Vector2.zero);

            // Check if the raycast hits this fish
            if (hit.collider != null)
            {
                Debug.Log("fish fast: Raycast Hit: " + hit.collider.gameObject.name);
                // If the fish is clicked, make it invisible
                hit.collider.gameObject.SetActive(false);
            }
        }
        }
    }
}
