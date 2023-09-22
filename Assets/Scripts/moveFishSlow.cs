using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFishSlow : MonoBehaviour
{
    public float speed = 2.5f;
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
    }
}
