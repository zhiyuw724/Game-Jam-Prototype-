using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class heatLevel : MonoBehaviour
{
    public TMP_Text textMeshPro;
    public int currentHeatLevel = 50;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Heat Level: " + currentHeatLevel;
    }

    public void IncreaseHeat()
    {
        currentHeatLevel += 15;
    }
    public void IncreaseHeatSecondLevel()
    {
        currentHeatLevel += 25;
    }

    public void DecreaseHeat()
    {
        currentHeatLevel -= 5;
    }
    public void MissedClick()
{
    DecreaseHeat();
}
}
