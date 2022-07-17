using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    int timerTime = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerTime > 0)
        {
            timerText.text = (timerTime--).ToString("20");
        }
        else
        {
            DiceThrow();
        }
    }
    void DiceThrow()
    {
        int randomThrow = Random.Range(1, 7);

    }
}
