using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class heatLevel : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public int currentHeatLevel = 200;


    public GameObject goldenFish;
    private bool isFrozen = false;
    private float freezeDuration = 2.0f;
    private float freezeTimer = 0.0f;
    public float speed = 20f;
    public float freezeSpeed = 0.0f;
    private moveFishGolden fishMovementScript;


    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
        fishMovementScript = goldenFish.GetComponent<moveFishGolden>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Heat Level: " + currentHeatLevel;


        if (Input.GetKeyDown(KeyCode.F) && currentHeatLevel >= 200 && !isFrozen)
        {
            FreezeFish();
            Debug.Log("Hello");
        }

        if (isFrozen)
        {
            freezeTimer += Time.deltaTime;
            Debug.Log(freezeTimer);
            if (freezeTimer >= freezeDuration)
            {
                UnfreezeFish();
            }
        }


    }

    void FreezeFish()
    {
        if (goldenFish != null)
        {
            // Disable the fish's movement or any other relevant script
            // For example, if you have a script controlling fish movement, you can disable it here
            // goldenFish.GetComponent<FishMovementScript>().enabled = false;
            isFrozen = true;
            freezeTimer = 0.0f; // Reset the freeze timer
            currentHeatLevel -= 100; // Decrease the heat level by 100
            if (fishMovementScript != null)
            {
                fishMovementScript.speed = 0.0f;
            }
        }
    }

    // Function to unfreeze the golden fish
    void UnfreezeFish()
    {
        if (goldenFish != null)
        {
            // Enable the fish's movement or any other relevant script
            // For example, if you have a script controlling fish movement, you can enable it here
            // goldenFish.GetComponent<FishMovementScript>().enabled = true;
            isFrozen = false;
            if (fishMovementScript != null)
            {
                fishMovementScript.speed = 20.0f;
            }
        }
    }
}
