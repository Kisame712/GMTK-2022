using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject[] panels = new GameObject[6] ;
    public Text timerText;
    int timerTime = 20;
    // Start is called before the first frame update
    void Start()
    {
        panels[0].SetActive(false);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
        panels[3].SetActive(false);
        panels[4].SetActive(false);
        panels[5].SetActive(false);

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
        panels[randomThrow - 1].SetActive(true);

    }
}
