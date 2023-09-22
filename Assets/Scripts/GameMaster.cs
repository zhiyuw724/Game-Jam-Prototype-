using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public bool runningTimer;
    public float currentTime;
    public float maxTime = 10;
    public TMPro.TextMeshProUGUI Text;
    public TMPro.TextMeshProUGUI GameOverText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        runningTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (runningTimer)
        {
            currentTime -= Time.deltaTime;
            Text.text = "Time: " + (int) currentTime;
            if (currentTime <= 0) {
                runningTimer = false;
                GameOverText.text = "GAME OVER!!!";
            }

        }
    }
}
