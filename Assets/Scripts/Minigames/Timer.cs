using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public float time;
    public bool timerOn;
    public GameObject wFinish;

    private void Start()
    {
        timerOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                timer.text = Mathf.RoundToInt(time).ToString();
            }
            else
            {
                time = 0;
                timer.text = Mathf.RoundToInt(time).ToString();
                timerOn = false;
                wFinish.SetActive(true);
            }
        }
    }
}
