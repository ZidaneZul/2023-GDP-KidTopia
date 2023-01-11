using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baby : MonoBehaviour
{
    public GameObject[] healthUI;
    public GameObject[] hungerUI;
    public GameObject[] happinessUI;
    public GameObject lose;
    public int health;
    public int hunger;
    public int happiness;

    private float hpt = 20;
    private float hgt = 15;
    private float hyt = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HealthTick();
        HungerTick();
        HappinessTick();
    }

    void HealthTick()
    {  
        if (hpt > 0)
        {
            hpt -= Time.deltaTime;
            Debug.Log(hpt);
        }
        else 
        {
            hpt = 20;
            if (health > 0)
            {
                health--;
                healthUI[4 - health].SetActive(false);
            } 
            else
            {
                lose.SetActive(true);
            }
        }
    }
    void HungerTick()
    {
        if (hgt > 0)
        {
            hgt -= Time.deltaTime;
            Debug.Log(hgt);
        }
        else
        {
            hgt = 15;
            if (hunger > 0)
            {
                hunger--;
                hungerUI[4 - hunger].SetActive(false);
            }
            else
            {
                lose.SetActive(true);
            }
        }
    }
    void HappinessTick()
    {
        if (hyt > 0)
        {
            hyt -= Time.deltaTime;
            Debug.Log(hyt);
        }
        else
        {
            hyt = 10;
            if (happiness > 0)
            {
                happiness--;
                happinessUI[4 - happiness].SetActive(false);
            }
            else
            {
                lose.SetActive(true);
            }
        }
    }
}
