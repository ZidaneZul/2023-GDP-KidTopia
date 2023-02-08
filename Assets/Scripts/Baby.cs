using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baby : MonoBehaviour
{
    public RandomEvents randomEvent;
    public GameObject[] healthUI;
    public GameObject[] hungerUI;
    public GameObject[] happinessUI;
    public GameObject lose;
    public GameObject rdmUI;
    public int health;
    public int hunger;
    public int happiness;
    public Sprite sHappy;
    public Sprite sNeutral;
    public Sprite sSad;
    public Sprite sCrying;

    private Image baby;

    private float rdm = 20;
    private float hgt = 15;
    private float hyt = 10;

    // Start is called before the first frame update
    void Start()
    {
        baby = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomTick();
        HungerTick();
        HappinessTick();
        if (happiness >= 5) 
        {
            baby.sprite = sHappy;
        }
        else if (happiness >= 3)
        {
            baby.sprite = sNeutral;
        }
        else if (happiness == 2)
        {
            baby.sprite = sSad;
        }
        else
        {
            baby.sprite = sCrying;
        }
    }
    void RandomTick()
    {
        if (rdm > 0)
        {
            rdm -= Time.deltaTime;
            Debug.Log("random tick" + rdm);
        }
        else
        {
            rdm = 20;
            rdmUI.SetActive(true);
            Time.timeScale = 0;
            randomEvent.RdmEvent();
        }
    }
    void HungerTick()
    {
        if (hgt > 0)
        {
            hgt -= Time.deltaTime;
            Debug.Log("hunger tick" + hgt);
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
            Debug.Log("happy tick" + hyt);
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
