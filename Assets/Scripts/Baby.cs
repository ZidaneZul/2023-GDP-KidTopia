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
    public static int health;
    public static int hunger;
    public static int happiness;
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
        HealthCheck();
        HungerTick();
        HungerCheck();
        HappinessTick();
        HappinessCheck();
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
    void HungerCheck()
    {
        if (hunger == 5)
        {
            hungerUI[0].SetActive(true);
            hungerUI[1].SetActive(true);
            hungerUI[2].SetActive(true);
            hungerUI[3].SetActive(true);
            hungerUI[4].SetActive(true);
        }
        else if (hunger == 4)
        {
            hungerUI[0].SetActive(false);
            hungerUI[1].SetActive(true);
            hungerUI[2].SetActive(true);
            hungerUI[3].SetActive(true);
            hungerUI[4].SetActive(true);
        }
        else if (hunger == 3)
        {
            hungerUI[0].SetActive(false);
            hungerUI[1].SetActive(false);
            hungerUI[2].SetActive(true);
            hungerUI[3].SetActive(true);
            hungerUI[4].SetActive(true);
        }
        else if (hunger == 2)
        {
            hungerUI[0].SetActive(false);
            hungerUI[1].SetActive(false);
            hungerUI[2].SetActive(false);
            hungerUI[3].SetActive(true);
            hungerUI[4].SetActive(true);
        }
        else if (hunger == 1)
        {
            hungerUI[0].SetActive(false);
            hungerUI[1].SetActive(false);
            hungerUI[2].SetActive(false);
            hungerUI[3].SetActive(false);
            hungerUI[4].SetActive(true);
        }
        else
        {
            hungerUI[0].SetActive(false);
            hungerUI[1].SetActive(false);
            hungerUI[2].SetActive(false);
            hungerUI[3].SetActive(false);
            hungerUI[4].SetActive(false);
        }
    }
    void HealthCheck()
    {
        if (health == 5)
        {
            healthUI[0].SetActive(true);
            healthUI[1].SetActive(true);
            healthUI[2].SetActive(true);
            healthUI[3].SetActive(true);
            healthUI[4].SetActive(true);
        }
        else if (health == 4)
        {
            healthUI[0].SetActive(false);
            healthUI[1].SetActive(true);
            healthUI[2].SetActive(true);
            healthUI[3].SetActive(true);
            healthUI[4].SetActive(true);
        }
        else if (health == 3)
        {
            healthUI[0].SetActive(false);
            healthUI[1].SetActive(false);
            healthUI[2].SetActive(true);
            healthUI[3].SetActive(true);
            healthUI[4].SetActive(true);
        }
        else if (health == 2)
        {
            healthUI[0].SetActive(false);
            healthUI[1].SetActive(false);
            healthUI[2].SetActive(false);
            healthUI[3].SetActive(true);
            healthUI[4].SetActive(true);
        }
        else if (health == 1)
        {
            healthUI[0].SetActive(false);
            healthUI[1].SetActive(false);
            healthUI[2].SetActive(false);
            healthUI[3].SetActive(false);
            healthUI[4].SetActive(true);
        }
        else
        {
            healthUI[0].SetActive(false);
            healthUI[1].SetActive(false);
            healthUI[2].SetActive(false);
            healthUI[3].SetActive(false);
            healthUI[4].SetActive(false);
        }
    }
    void HappinessCheck()
    {
        if (happiness == 5)
        {
            baby.sprite = sHappy;
            happinessUI[0].SetActive(true);
            happinessUI[1].SetActive(true);
            happinessUI[2].SetActive(true);
            happinessUI[3].SetActive(true);
            happinessUI[4].SetActive(true);
        }
        else if (happiness == 4)
        {
            baby.sprite = sHappy;
            happinessUI[0].SetActive(false);
            happinessUI[1].SetActive(true);
            happinessUI[2].SetActive(true);
            happinessUI[3].SetActive(true);
            happinessUI[4].SetActive(true);
        }
        else if (happiness == 3)
        {
            baby.sprite = sNeutral;
            happinessUI[0].SetActive(false);
            happinessUI[1].SetActive(false);
            happinessUI[2].SetActive(true);
            happinessUI[3].SetActive(true);
            happinessUI[4].SetActive(true);
        }
        else if (happiness == 2)
        {
            baby.sprite = sSad;
            happinessUI[0].SetActive(false);
            happinessUI[1].SetActive(false);
            happinessUI[2].SetActive(false);
            happinessUI[3].SetActive(true);
            happinessUI[4].SetActive(true);
        }
        else if (happiness == 1)
        {
            baby.sprite = sCrying;
            happinessUI[0].SetActive(false);
            happinessUI[1].SetActive(false);
            happinessUI[2].SetActive(false);
            happinessUI[3].SetActive(false);
            happinessUI[4].SetActive(true);
        }   
        else
        {
            baby.sprite = sCrying;
            happinessUI[0].SetActive(false);
            happinessUI[1].SetActive(false);
            happinessUI[2].SetActive(false);
            happinessUI[3].SetActive(false);
            happinessUI[4].SetActive(false);
        }
    }
}
